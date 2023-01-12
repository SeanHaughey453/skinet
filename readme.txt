mkdir (name of folder)

dotnet -h 

dotnet new -l

dotnet new webapi -o API

dotnet sln -h

dotnet sln add .\API\  

add in dotnet 6 startup and program files




Database stuff i ran to create the code first from the enttity frame work

-p is the project folder your looking to target
-s is the start up folder
-o is the output folder you are targeting which derives from the -p folder speicfied 

dotnet ef database drop -p .\Infrastructure\ -s .\API\    

dotnet ef migrations remove -p .\Infrastructure\ -s .\API\

dotnet ef migrations add InitialCreate -p .\Infrastructure\ -s .\API\ -o Data/Migrations

to reference modal(object /db table) in anothe modal and then reference a 3rd modal related tothe second modal follow the resource in the e commerce apps folder and this link to help understand
https://stackoverflow.com/questions/49668851/using-include-vs-theninclude#:~:text=The%20difference%20is%20that%20Include,if%20you%20only%20used%20Include. 

angular front end 
 first off i will be using ngx bootstrap so i must check the compatbility ie angular 15 is compatable with ngx-bootsrap 10- https://valor-software.com/ngx-bootstrap/#/documentation#getting-started


ssl certs pt 74

