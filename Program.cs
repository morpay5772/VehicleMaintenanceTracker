/*
Name: Moriah Payne
Date: 6/15/2025
Assignment: SDC320 Course Project Week 5
Description: demonstrates the use of classes, manages application, interacts with user
*/
using System.Data.SQLite;
using System.Collections.Generic;

public class DBExample
{
    public static void Main(string[] args)
    {
        const string dbName = "MoriahPayne.db";
        Console.WriteLine("\nMoriah Payne Week 4 Course Project - Vehicle Maintenance Tracker\n");

        // Connect to SQLite database
        SQLiteConnection conn = SQLiteDatabase.Connect(dbName);
        if (conn != null)
        {
            //create Vehicles table
            VehicleDb.CreateTable(conn);
            //add vehicle records
            VehicleDb.AddVehicle(conn, new Vehicle(0, "Honda", "Civic", 2015, "1HGCM82633A123456"));
            VehicleDb.AddVehicle(conn, new Vehicle(0, "Ford", "Escape", 2020, "1FMCU9GD0KUA12345"));
            VehicleDb.AddVehicle(conn, new Vehicle(0, "Toyota", "Camry", 2018, "4T1BF1FK5JU123456"));
            VehicleDb.AddVehicle(conn, new Vehicle(0, "Chevrolet", "Malibu", 2022, "1G1ZD5ST5NF123456"));
            //list all vehicles
            Console.WriteLine("\nAll Vehicles in the Database");
            PrintVehicles(VehicleDb.GetAllVehicles(conn));
            //get a vehicle with an invalid ID
            Console.WriteLine("\nGet a Vehicle Using an Invalid ID");
            PrintVehicle(VehicleDb.GetVehicle(conn, -5));
            //update a vehicle record
            Vehicle vehicleToUpdate = new Vehicle(2, "Ford", "Escape SEL AWD", 2020, "1FMCU9GD0KUA12345");
            VehicleDb.UpdateVehicle(conn, vehicleToUpdate);
            //return the updated vehicle
            Vehicle updatedVehicle = VehicleDb.GetVehicle(conn, vehicleToUpdate.VehicleId);
            Console.WriteLine("\nUpdated Vehicle");
            PrintVehicle(updatedVehicle);
            //delete a vehicle record
            VehicleDb.DeleteVehicle(conn, vehicleToUpdate.VehicleId);
            //list all vehicles again after deletion
            Console.WriteLine("\nAll Vehicles in the Database After Deletion");
            PrintVehicles(VehicleDb.GetAllVehicles(conn));
        }
    }  
    //print a list of vehicles
    private static void PrintVehicles(List<Vehicle> vehicles)
    {
        foreach (Vehicle v in vehicles)
        {
            PrintVehicle(v);
        }
    }
    //print a single vehicle's details
    private static void PrintVehicle(Vehicle v)
    {
        Console.WriteLine("Vehicle " + v.VehicleId + ": ");
        Console.WriteLine(v.ToString() + "\n");
    }
}