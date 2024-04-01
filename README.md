# Learn Framework Entity
Project dimana saya belajar ORM entity framework

## Migration
### Package
```powerShell
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
```
### Command for migration
```powerShell 
dotnet tool install --global dotnet-ef
dotnet ef migrations add Initial
dotnet ef database update
```

