# ---------- Build ----------
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

COPY Portfolio.sln ./
COPY PersonalPortfolio/PersonalPortfolio.csproj ./PersonalPortfolio/

RUN dotnet restore

COPY . ./

RUN dotnet publish PersonalPortfolio/PersonalPortfolio.csproj -c Release -o /app/publish --no-restore

# ---------- Run ----------
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS runtime
WORKDIR /app

COPY --from=build /app/publish ./

EXPOSE 8080

CMD ["sh", "-c", "ASPNETCORE_URLS=http://0.0.0.0:${PORT:-8080} dotnet PersonalPortfolio.dll"]