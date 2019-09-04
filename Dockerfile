FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 5000

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY SimonBus_Config.Web/SimonBus_Config.Web.csproj SimonBus_Config.Web/
COPY SimonBus_Config.Services/SimonBus_Config.Services.csproj SimonBus_Config.Services/
COPY SimonBus_Config.Core/SimonBus_Config.Core.csproj SimonBus_Config.Core/
COPY SimonBus_Config.Repositories/SimonBus_Config.Repositories.csproj SimonBus_Config.Repositories/
RUN dotnet restore "SimonBus_Config.Web/SimonBus_Config.Web.csproj" -s http://127.0.0.1:9988 -s https://api.nuget.org/v3/index.json
COPY . .
WORKDIR "/src/SimonBus_Config.Web"
RUN dotnet build "SimonBus_Config.Web.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "SimonBus_Config.Web.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "SimonBus_Config.Web.dll"]
