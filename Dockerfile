FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 5000

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["SimonBus_Config.Web/SimonBus_Config.Web.csproj", "SimonBus_Config.Web/"]
RUN dotnet restore "SimonBus_Config.Web/SimonBus_Config.Web.csproj" -s http://192.168.31.78:9988
COPY . .
WORKDIR "/src/SimonBus_Config.Web"
RUN dotnet build "SimonBus_Config.Web.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "SimonBus_Config.Web.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "SimonBus_Config.Web.dll"]