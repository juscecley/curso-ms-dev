FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["CursoMsDev/CursoMsDev.csproj", "CursoMsDev/"]
RUN dotnet restore "CursoMsDev/CursoMsDev.csproj"
COPY . .
WORKDIR "/src/CursoMsDev"
RUN dotnet build "CursoMsDev.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CursoMsDev.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CursoMsDev.dll"]
