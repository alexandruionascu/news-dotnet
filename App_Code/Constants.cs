using System;
using System.IO;

/// <summary>
/// Summary description for Constants
/// </summary>
public class Constants
{
    
        private static readonly string PATH = Directory.GetParent(
            Directory.GetParent(Directory.GetCurrentDirectory()).ToString()
        ).ToString();

    public static readonly string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database.mdf;Integrated Security=True";
    
}