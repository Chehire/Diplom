﻿using System.Data;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Win32;

public class DatabaseConnection
{
    public static string DS = "Empty", IC = "Empty", UI = "Empty", PW = "Empty";
    public static string error_message = "App:start:" + DateTime.Now.ToLongDateString();
    public static SqlConnection sqlConnection = new SqlConnection();

    public void Registry_Get()
    {
        RegistryKey registry = Registry.CurrentUser;
        RegistryKey key = registry.CreateSubKey("Compo");
        try
        {
            DS = key.GetValue("DS").ToString();
            IC = key.GetValue("IC").ToString();
            UI = key.GetValue("UI").ToString();
            PW = key.GetValue("PW").ToString();
        }
        catch
        {
            key.SetValue("DS", "Empty");
            key.SetValue("IC", "Empty");
            key.SetValue("UI", "Empty");
            key.SetValue("PW", "Empty");
        }
        finally
        {
            sqlConnection.ConnectionString = "Data Source = " + DS +
                "; Initial Catalog = " + IC + "; Persist Security Info = true; " +
                "User ID = " + UI + "; Password = \"" + PW + "\"";
        }
    }

    public void Registry_Set(string ds, string ic, string ui, string pw)
    {
        RegistryKey registry = Registry.CurrentUser;
        RegistryKey key = registry.CreateSubKey("Compo");
        try
        {
            key.SetValue("DS", ds);
            key.SetValue("IC", ic);
            key.SetValue("UI", ui);
            key.SetValue("PW", pw);
            Registry_Get();
        }
        catch (Exception ex)
        {
            error_message += "\n" + DateTime.Now.ToLongDateString() + ex.Message;
        }
    }

    public SqlConnection DatabaseSQL()
    {
        return sqlConnection;
    }


    public DataSet TableFill(string query, SqlConnection sql)
    {
        SqlDataAdapter adapter = new SqlDataAdapter(query, sql);
        var dataSet = new DataSet();
        dataSet.Clear();
        adapter.Fill(dataSet);
        return dataSet;
    }
}
