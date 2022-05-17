# RazorPagesMovie
ASP.NET Core 6.0 Tutorial build from the [documentation](https://www.bing.com/ck/a?!&&p=f653d26ccee578ca133243ff7999b6548d60e42aa01b5037aa3b1db056b8fbf0JmltdHM9MTY1Mjc0OTU0NCZpZ3VpZD02ZmIxNGNmOC04OGZhLTRjYzAtODFjYy00MmZiNDZkZmU2NzcmaW5zaWQ9NTE2Mw&ptn=3&fclid=7a7b7973-d57d-11ec-b612-eb6d61d03f47&u=a1aHR0cHM6Ly9kb2NzLm1pY3Jvc29mdC5jb20vZW4tdXMvYXNwbmV0L2NvcmUvdHV0b3JpYWxzL3Jhem9yLXBhZ2VzL3Jhem9yLXBhZ2VzLXN0YXJ0&ntb=1)

## Database
SQL Server Express LocalDB is used at the C:\Users\<user>\ directory and creates .mdf files locally.

From the Tools menu, select NuGet Package Manager > Package Manager Console.
> Update-Database

Connection string should not be pushed to repo in good practice. The appsettings.json file is stored locally.

[Source](https://mariliisjaago.com/2021/03/08/using-git-ignore-to-hide-your-connection-strings/#:~:text=In%20the%20VS%20solution%20folder%2C%20you%20have%20a,version%20control%2C%20and%20therefore%20to%20your%20online%20repo.)

TODO: When the app is deployed to a test or production server, an environment variable can be used to set the connection string to a test or production database server. For more information, see [Configuration](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/configuration/?view=aspnetcore-6.0). 
