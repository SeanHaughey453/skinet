Database stuff i ran to create the code first from the enttity frame work

-p is the project folder your looking to target
-s is the start up folder
-o is the output folder you are targeting which derives from the -p folder speicfied 

dotnet ef database drop -p .\Infrastructure\ -s .\API\    

dotnet ef migrations remove -p .\Infrastructure\ -s .\API\

dotnet ef migrations add InitialCreate -p .\Infrastructure\ -s .\API\ -o Data/Migrations

