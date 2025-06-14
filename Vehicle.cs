/*
Name: Moriah Payne
Date: 6/15/2025
Assignment: SDC320 Course Project Week 5
Description: inherits from VehicleBase and implements IMaintainable. Represents specific type of vehicle with ability to receive and track maintenance
*/
public class Vehicle : VehicleBase, IMaintainable
{ 
    public Vehicle() { }
    public Vehicle(int vehicleId, string make, string model, int year, string vin)
    {
        VehicleId = vehicleId;
        Make = make;
        Model = model;
        Year = year;
        VIN = vin;
    }
    public override string GetVehicleInfo()
    {
        return $"Vehicle ID: {VehicleId}\nMake: {Make}\nModel: {Model}\nYear: {Year}\nVIN: {VIN}";
    }
    public string GetMaintenanceStatus()
    {
        return $"Vehicle {Make} {Model} maintenance check pending.";
    }
    public override string ToString()
    {
        return GetVehicleInfo();
    }
}