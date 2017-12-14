using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

/// <summary>
/// Summary description for User
/// </summary>
public class User {
    public string username { get; set; }
    public string password { get; set; }
    private string table;
    
    public User (string table) {
        this.table = table;
    }

    public string generateInsertQuery() {
        var columnNames = "";
        var values = "";
        var properties = typeof(User).GetProperties();
        foreach (var property in properties) {
            var name = property.Name;
            var value = this.GetType().GetProperty(name).GetValue(this, null);
            if (value != null) {
                columnNames += (columnNames.Length == 0 ? "" : ",") + name;
                values += (values.Length == 0 ? "" : ",") + value;
            }
        }

        return String.Format("INSERT INTO {0} ({1}) VALUES ({2});", table, columnNames, values);
    }
}