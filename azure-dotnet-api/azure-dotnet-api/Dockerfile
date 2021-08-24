FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY bin/release/net5.0/publish/ ./
ENTRYPOINT ["dotnet", "azure-dotnet-api.dll"]