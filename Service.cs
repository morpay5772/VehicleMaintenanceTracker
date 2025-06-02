/*
Name: Moriah Payne
Date: 6/1/2025
Assignment: SDC320 Course Project Week 3
*/
public class Service
{
    public int ServiceId { get; set; }
    public string? Description { get; set; }
    public Service() { }
    public Service(int serviceId, string description)
    {
        ServiceId = serviceId;
        Description = description;
    }
    public override string ToString()
    {
        return $"Service ID: {ServiceId}\nDescription: {Description}";
    }
}