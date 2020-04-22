# Image for run
FROM mcr.microsoft.com/dotnet/core/aspnet:2.1-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Image for build
FROM mcr.microsoft.com/dotnet/core/sdk:2.1-stretch AS build
WORKDIR /src

# Copy csproj and restore as distinct layers
COPY ["csharp-dotnetcore-projects.csproj", ""]
RUN dotnet restore "csharp-dotnetcore-projects.csproj"

# Copy everything else and build
COPY . .
WORKDIR "/src/"
RUN dotnet build "csharp-dotnetcore-projects.csproj" -c Release -o /app

# Build runtime image
FROM build AS publish
RUN dotnet publish "csharp-dotnetcore-projects.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "csharp-dotnetcore-projects.dll"]
