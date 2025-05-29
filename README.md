### For each solution, you must import BACPAC file into **SQL Server Management Studio Management Studio** or any Database, after you go to Web.config to change *<connectionStrings>*
```
<connectionStrings>
  <add name="{{yourString}}" connectionString="Data Source = {{Server Name}}; database = {{Database Name}}; Integrated Security = true;" />
</connectionStrings>
```
