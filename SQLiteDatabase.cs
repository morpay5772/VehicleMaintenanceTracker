/*
Name: Moriah Payne
Date: 6/8/2025
Assignment: SDC320 Course Project Week 4
*/
using System.Data.SQLite;
public class SQLiteDatabase
{ 
    public static SQLiteConnection Connect(string database)
    {
        string cs = @"Data Source=" + database;
        SQLiteConnection conn = new SQLiteConnection(cs);
        try
        {
            conn.Open();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        return conn;
    }
}