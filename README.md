# AlexSouchereau_WEB315Assignments
 
dotnet new blazorwasm -ho -o AlexSouchereauChat --no-https -f net5.0
cd .\AlexSouchereauChat\Client\
dotnet new razorcomponent -n Chat -o Pages
dotnet add package Microsoft.AspNetCore.SignalR.Client --version 5.0.16