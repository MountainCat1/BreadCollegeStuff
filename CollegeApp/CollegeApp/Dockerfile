FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["CollegeApp/CollegeApp.csproj", "CollegeApp/"]
RUN dotnet restore "CollegeApp/CollegeApp.csproj"
COPY . .
WORKDIR "/src/CollegeApp"
RUN dotnet build "CollegeApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CollegeApp.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CollegeApp.dll"]
