FROM mcr.microsoft.com/dotnet/runtime:8.0
WORKDIR /App
COPY bin/Release/net8.0/publish /App/
ENTRYPOINT ["dotnet", "/App/ConsoleApp.dll"]