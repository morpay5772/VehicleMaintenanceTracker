/*
Name: Moriah Payne
Date: 6/8/2025
Assignment: SDC320 Course Project Week 4
*/
using System.Collections.Generic;
public abstract class VehicleBase
{ 
    public int VehicleId { get; set; }
    public string? Make { get; set; }
    public string? Model { get; set; }
    public int Year { get; set; }
    public string? VIN { get; set; }
    public abstract string GetVehicleInfo();
}