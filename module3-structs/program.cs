// This 

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

// Returns a collection of locations with the correct value for each field and writes them to the console
class Program
{
    static void Main()
    {
        // Declare a variable with our GeoCoord constructor with needed values
        GeoCoord location = new GeoCoord("Null Island", 0.000000, 0.000000, "Landmark");
        Console.WriteLine($"Name: {location.name}, Latitude: {location.lat}, Longitude: {location.lon}, Type: {location.type}");

        // A ref struct that's kept in heap to be used later.
        GeoCoord locationRef;
        Console.WriteLine($"Name: {locationRef.name = "Palm Beach State College"}, Latitude: {locationRef.lat = 26.376310}, Longitude: {locationRef.lon = -80.099020}, Type: {locationRef.type = "College"}");
        Console.WriteLine($"Name: {locationRef.name = "Microsoft Corporation"}, Latitude: {locationRef.lat = 47.641944}, Longitude: {locationRef.lon = -122.127222}, Type: {locationRef.type = "Business"}");
    }

}

