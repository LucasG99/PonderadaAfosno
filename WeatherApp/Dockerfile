FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["WeatherApp.csproj", "./"]
RUN dotnet restore "WeatherApp.csproj"
COPY . .
RUN dotnet build "WeatherApp.csproj" -c Release -o /app/build --no-restore
RUN dotnet publish "WeatherApp.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
EXPOSE 8080
ENV ASPNETCORE_URLS=http://+:8080
ENTRYPOINT ["dotnet", "WeatherApp.dll"] 