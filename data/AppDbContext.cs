using System;

namespace Company.ClassLibrary1;

public class AppDbContext : AppDbContext
{
    public DbSet<producto> Productos {get;set;}
    protected override void OnConfiguring(DbContextOptionesBuilder OptionsBuilder)
    {
        var connectionString = "Server=localhost;Database=TiendaPedro;User=root;Password=tupass;";
        Mysql(connectionString,ServerVersion.AutoDetect(connectionString));
    }
}
