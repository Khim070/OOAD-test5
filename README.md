# OOAD-test4
 ProductPricing

1. dotnet new sln -o ProductPricing -n ProductPricing
2. dotnet new classlib -o ./ProductPricing/Library -n ProductLib
3. cd productpricing
4. dotnet sln add ./library/productlib.csproj
5. dotnet new console -o Console -n ProductConsole --use-program-main
6. dotnet sln add console/productconsole.csproj
7. cd console
8. dotnet add reference ../library/Productlib.csproj
