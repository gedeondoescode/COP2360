// This is a usage exmaple of defining structs similar to what was provided in   

using System;

struct GeoCoord
{
    public string name;
    public double lat, lon;
    public string type;

    // Constructor to read and reference the field values
    public GeoCoord(string locationName, double latitude, double longitude, string locationType)
    {
        name = locationName;
        lat = latitude;
        lon = longitude;
        type = locationType;
    }
};

// using ref to ensure Car always lives on stack
ref struct Car 
{
    public readonly int year = 2019;
    public string make;
    public string model;
}

// Returns a collection of locations with the correct value for each field and writes them to the console
class Program
{
    static void Main()
    {
        // Declare a variable with our GeoCoord constructor with needed values
        GeoCoord location = new GeoCoord("Null Island", 0.000000, 0.000000, "Landmark");
        Console.WriteLine($"Name: {location.name}, Latitude: {location.lat}, Longitude: {location.lon}, Type: {location.type}");

        // A struct kept on stack to be used later.
        GeoCoord locationRef;
        Console.WriteLine($"Name: {locationRef.name = "Palm Beach State College"}, Latitude: {locationRef.lat = 26.376310}, Longitude: {locationRef.lon = -80.099020}, Type: {locationRef.type = "College"}");
        Console.WriteLine($"Name: {locationRef.name = "Microsoft Corporation"}, Latitude: {locationRef.lat = 47.641944}, Longitude: {locationRef.lon = -122.127222}, Type: {locationRef.type = "Business"}");

        // This will always return bitwise 0 or null (i.e. they're at their default values)
        Car carDefault = default;
        Console.WriteLine($"Year: {carDefault.year}, Make: {carDefault.make}, Model: {carDefault.model}");
    }
}


class CarClass 
{
    Car carVar; //without ref for Car, carVar will live on heap. With ref, this will not compile 
}
