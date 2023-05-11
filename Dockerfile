FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Sportsbot.csproj", "./"]
RUN dotnet restore "Sportsbot.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "Sportsbot.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Sportsbot.csproj" -c Release -r win10-x64 --self-contained false -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Sportsbot.dll"]
