﻿FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["AdminPanel/AdminPanel.csproj", "AdminPanel/"]
RUN dotnet restore "AdminPanel/AdminPanel.csproj"
COPY . .
WORKDIR "/src/AdminPanel"
RUN dotnet build "AdminPanel.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AdminPanel.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AdminPanel.dll"]
