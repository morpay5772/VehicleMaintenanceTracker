/*
Name: Moriah Payne
Date: 6/15/2025
Assignment: SDC320 Course Project Week 
Description: abstract base class for vehicles, contains common properties, used for polymorphism across different vehicle types
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