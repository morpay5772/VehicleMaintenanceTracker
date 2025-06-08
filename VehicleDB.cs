/*
Name: Moriah Payne
Date: 6/8/2025
Assignment: SDC320 Course Project Week 4
*/
using System.Data.SQLite;
public class VehicleDb
{
    //creates the Vehicles table if it doesn't exist
    public static void CreateTable(SQLiteConnection conn)
    {
        string sql = 
        "CREATE TABLE IF NOT EXISTS Vehicles (\n"
        + " VehicleId integer PRIMARY KEY\n"
        + " ,Make varchar(20)\n"
        + " ,Model varchar(20)\n"
        + " ,Year integer\n"
        + " ,VIN varchar(20));";
        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        cmd.ExecuteNonQuery();
    }
    //adds a new Vehicle record to the database
    public static void AddVehicle(SQLiteConnection conn, Vehicle v)
    {
        string sql = string.Format(
            "INSERT INTO Vehicles (Make, Model, Year, VIN) " +
            "VALUES ('{0}', '{1}', {2}, '{3}')",
            v.Make, v.Model, v.Year, v.VIN);
        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        cmd.ExecuteNonQuery();
    }
    //updates an existing Vehicle record
    public static void UpdateVehicle(SQLiteConnection conn, Vehicle v)
    {
        string sql = string.Format(
            "UPDATE Vehicles SET Make='{0}', Model='{1}', Year={2}, VIN='{3}' " +
            "WHERE VehicleId={4}",
            v.Make, v.Model, v.Year, v.VIN, v.VehicleId);
        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        cmd.ExecuteNonQuery();
    }
    //deletes a Vehicle by its ID
    public static void DeleteVehicle(SQLiteConnection conn, int id)
    {
        string sql = string.Format($"DELETE FROM Vehicles WHERE VehicleId = {id}");
        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        cmd.ExecuteNonQuery();
    }
    //returns all Vehicle records from the database
    public static List<Vehicle> GetAllVehicles(SQLiteConnection conn)
    {
        List<Vehicle> vehicles = new List<Vehicle>();
        string sql = "SELECT * FROM Vehicles";
        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        SQLiteDataReader rdr = cmd.ExecuteReader();
        while (rdr.Read())
        {
            vehicles.Add(new Vehicle(
                rdr.GetInt32(0),
                rdr.GetString(1),
                rdr.GetString(2),
                rdr.GetInt32(3),
                rdr.GetString(4)
            ));
        }
        return vehicles;
    }
    //returns a single Vehicle by its ID
    public static Vehicle GetVehicle(SQLiteConnection conn, int id)
    {
        string sql = string.Format($"SELECT * FROM Vehicles WHERE VehicleId = {id}");
        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        SQLiteDataReader rdr = cmd.ExecuteReader();
        if (rdr.Read())
        {
            return new Vehicle(
                rdr.GetInt32(0),
                rdr.GetString(1),
                rdr.GetString(2),
                rdr.GetInt32(3),
                rdr.GetString(4)
            );
        }
        else
        {
            //returns a placeholder vehicle if not found
            return new Vehicle(-1, string.Empty, string.Empty, 0, string.Empty);
        }
    }
}