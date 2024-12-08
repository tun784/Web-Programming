### For each solution, you must import BACPAC file into **SQL Server Management Studio Management Studio** or any Server Management, after you go to Web.config to change the *<connectionStrings>* element:
```
<connectionStrings>
  <add name="{yourString}" connectionString="Data Source = {Server Name}; Initial Catalog = {Database Name}; {Integrated Security = true;} {User ID = sa; Password=123;} "/>
</connectionStrings>
```
### After set up in Web.config, you declare a variable used as a connection string in **Controllers**:
```
string {variable} = ConfigurationManager.ConnectionStrings["{yourString}"].ConnectionString;
```
### Then you declare this library in that **Controllers**:
```
using System.Configuration;
```
