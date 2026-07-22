
    // TODO Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary

using System.Collections.Generic;

public class FeatureCollection
{
    public List<Feature> Features { get; set; }
}

public class Feature
{
    public EarthquakeProperties Properties { get; set; }
}

public class EarthquakeProperties
{
    public string Place { get; set; }
    public double Mag { get; set; }
}
