/*
Name: Moriah Payne
Date: 6/1/2025
Assignment: SDC320 Course Project Week 3
*/
public class Vehicle
{
    public int VehicleId { get; set; }
    public string? Make { get; set; }
    public string? Model { get; set; }
    public int Year { get; set; }
    public string? VIN { get; set; }
    public Vehicle() { }
    public Vehicle(int vehicleId, string make, string model, int year, string vin)
    {
        VehicleId = vehicleId;
        Make = make;
        Model = model;
        Year = year;
        VIN = vin;
    }
    public override string ToString()
    {
        return $"Vehicle ID: {VehicleId}\nMake: {Make}\nModel: {Model}\nYear: {Year}\nVIN: {VIN}";
    }
}