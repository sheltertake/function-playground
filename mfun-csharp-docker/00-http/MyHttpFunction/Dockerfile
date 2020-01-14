# --------------------------------------------------------------------------------------------------------------------------------------------
# stage build azure function
# --------------------------------------------------------------------------------------------------------------------------------------------
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-af
WORKDIR /app

# build prj
COPY . ./source/

WORKDIR /app/source/
RUN dotnet restore
RUN dotnet build

# publish application
WORKDIR /app/source/
RUN dotnet publish -c Release -o ../out

# --------------------------------------------------------------------------------------------------------------------------------------------
# stage runtime
# --------------------------------------------------------------------------------------------------------------------------------------------
FROM mcr.microsoft.com/azure-functions/dotnet:3.0 AS runtime
ENV AzureWebJobsScriptRoot=/home/site/wwwroot

# TO LOG IN CONSOLE
ENV AzureFunctionsJobHost__Logging__Console__IsEnabled=true

WORKDIR /
COPY --from=build-af /app/out ./home/site/wwwroot
