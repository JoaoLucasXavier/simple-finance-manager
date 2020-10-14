dotnet ef migrations add Initial -s sfm.Web -p sfm.Infra --context Context -v
dotnet ef database update -s sfm.Web -p sfm.Infra --context Context -v
