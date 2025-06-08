/*
Name: Moriah Payne
Date: 6/8/2025
Assignment: SDC320 Course Project Week 4
*/
public class MaintenanceRecord
{ 
    public int RecordId { get; set; }
    public int VehicleId { get; set; }
    public int ServiceId { get; set; }
    public string? ServiceDate { get; set; }
    public double Cost { get; set; }
    public string? NextDueDate { get; set; }
    public MaintenanceRecord() { }
    public MaintenanceRecord(int recordId, int vehicleId, int serviceId, string serviceDate, double cost, string nextDueDate)
    {
        RecordId = recordId;
        VehicleId = vehicleId;
        ServiceId = serviceId;
        ServiceDate = serviceDate;
        Cost = cost;
        NextDueDate = nextDueDate;
    }
    public override string ToString()
    {
        return $"Record ID: {RecordId}\nVehicle ID: {VehicleId}\nService ID: {ServiceId}\nDate: {ServiceDate}\nCost: ${Cost:F2}\nNext Due: {NextDueDate}";
    }
}