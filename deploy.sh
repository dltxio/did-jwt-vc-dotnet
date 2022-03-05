echo "deploy did.models"
cd src/did.jwt.vc.net
dotnet build
dotnet pack
cd bin/Debug
dotnet nuget push did.models.net.$1.nupkg -k xxx -s https://api.nuget.org/v3/index.json
cd ../../..
