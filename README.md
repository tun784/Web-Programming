<h3>For each solution, you must import BACPAC file into <em>SQL Server Management Studio Management Studio</em> or any server management system, then you go to <em>Web.config</em> to change the <code><em>connectionStrings</em></code> element:</h3>

```
<connectionStrings>
  <add name="{yourString}" connectionString="Data Source = {Server Name}; Initial Catalog = {Database Name}; {Integrated Security = true;} {User ID = sa; Password=123;} "/>
</connectionStrings>
```

<h3>After set up in <em>Web.config</em>, you declare a variable used as a connection string in the <em>Controllers</em>:</h3>

```
string {variable} = ConfigurationManager.ConnectionStrings["{yourString}"].ConnectionString;
```

<h3>Then you declare this library in the <em>Controllers</em>:</h3>

```
using System.Configuration;
```
