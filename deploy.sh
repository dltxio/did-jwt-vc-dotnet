echo "deploy did.models"
cd src/did.jwt.vc.net
dotnet build
dotnet pack
cd bin/Debug
dotnet nuget push did.Models.$1.nupkg -k oy2nydn7sg7dqxn7pciaedngu2zybzwurbkq2o5xrmiquy -s https://api.nuget.org/v3/index.json
cd ../../..