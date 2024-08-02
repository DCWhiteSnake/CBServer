##DB SETUP PWSH script
dotnet user-secrets init
type .\devconnectionstrings.json | dotnet user-secrets set

