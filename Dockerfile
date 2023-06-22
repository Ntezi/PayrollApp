FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["PayrollApp.csproj", "./"]
RUN dotnet restore "PayrollApp.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "PayrollApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PayrollApp.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PayrollApp.dll"]
