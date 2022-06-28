using System;
using System.IO;
using System.Data.Common;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
namespace Prn.Se1621;

public class Program
{
    public static void Main()
    {
        IEnumerable<Product>? products = GetAllProduct();
        foreach(Product? product in products){
            Console.WriteLine(product);
        }
        
        Console.ReadLine();
    }

    //Read content from the setting.json
    private static string GetConnectionString()
    {
        IConfiguration config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("Appsettings.json", true, true)
            .Build();
        return config["ConnectionStrings:AppDatabasePRN211"];
    }

    public static List<Product>? GetAllProduct(){
        //0. vSQL
        string vSQL = "select * from Products";
        List<Product> products = new List<Product>();
        //1. init provider
        DbProviderFactory factory = SqlClientFactory.Instance; //Signleton
        //2. init connection to database
        using DbConnection? conn = factory.CreateConnection();
        if(conn == null)
        {
            Console.WriteLine("init connection fail...");
            return null;
        }
        conn.ConnectionString = GetConnectionString();
        conn.Open();
        //3. init command (SQL/Stored Procedure)
        using DbCommand? cmd = factory.CreateCommand();
        if (cmd == null)
        {
            Console.WriteLine("init connection fail(cmd)...");
            return null;
        }
        cmd.CommandText = vSQL;
        cmd.Connection = conn;
        //4. Excute command
        using DbDataReader reader = cmd.ExecuteReader();
        //5. Reader
        if (reader.HasRows)
        {
            products = new List<Product>();
            while (reader.Read())
            {
                //1 init a product
                Product p = new Product();
                p.Id = (int)reader["ProductId"];
                p.ProductName = (string)reader["ProductName"];
                p.CategoryId = (int)reader["CategoryId"];
                p.Price = Convert.ToDouble(reader["UnitPrice"]);
                //2.add to list prodcut
                products.Add(p);
            }
            return products;
        }
        return null;
    }
}