FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["TAPAS.APP.UI/TAPAS.APP.UI.csproj", "TAPAS.APP.UI/"]
RUN dotnet restore "TAPAS.APP.UI/TAPAS.APP.UI.csproj"
COPY . .
WORKDIR "/src/TAPAS.APP.UI"
RUN dotnet build "TAPAS.APP.UI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TAPAS.APP.UI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "TAPAS.APP.UI.dll"]

CMD ASPNETCORE_URLS=http://*:$PORT dotnet tapas-app.dll