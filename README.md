# AlexSouchereau_WEB315Assignments
 
dotnet new webapp -o BeautifulNationalParks
cd BeautifulNationalParks
dotnet watch run
ctrl+c

dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.*
dotnet add package Microsoft.EntityFrameworkCore.SQLite --version 5.*
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 5.*
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.*

dotnet-aspnet-codegenerator razorpage -m Park -dc BeautifulNationalParksContext -udl -outDir Pages/Parks --referenceScriptLibraries -sqlite

dotnet ef migrations add InitialCreate
dotnet ef database update

dotnet watch run

