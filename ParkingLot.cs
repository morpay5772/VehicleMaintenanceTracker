/*
Name: Moriah Payne
Date: 6/8/2025
Assignment: SDC320 Course Project Week 4
*/
public class ParkingLot
{ 
    public List<Vehicle> Vehicles { get; set; }
    public ParkingLot()
    {
        Vehicles = new List<Vehicle>();
    }
    public void AddVehicle(Vehicle v)
    {
        Vehicles.Add(v);
    }
    public void DisplayAllVehicles()
    { 
        foreach (var v in Vehicles)
        {
            Console.WriteLine(v);
        }
    }
}