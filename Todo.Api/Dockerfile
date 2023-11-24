FROM mcr.microsoft.com/dotnet/sdk:8.0 AS base
WORKDIR /app
COPY TodoApi.csproj ./
RUN dotnet restore
COPY . .
RUN dotnet publish -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
ENV ASPNETCORE_URLS=http://+:5000
WORKDIR /app
COPY --from=base /app/publish .
ENTRYPOINT ["dotnet", "TodoApi.dll"]