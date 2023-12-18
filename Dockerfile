FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 8018

FROM mcr.microsoft.com/dotnet/sdk:7.0 as build
WORKDIR /src

COPY "./MockDogApiDec18.csproj" ./
RUN dotnet restore "./MockDogApiDec18.csproj"

COPY . .
RUN dotnet build "./MockDogApiDec18.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "./MockDogApiDec18.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT [ "dotnet", "MockDogApiDec18.dll" ]