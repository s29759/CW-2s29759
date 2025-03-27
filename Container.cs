namespace ConsoleApp1;

abstract class Container
{
    public double LoadMass { get; set; }
    public double Height { get; }
    public double OwnWeight { get; }
    public double Depth { get; }
    public string SerialNumber { get; }
    public double MaxLoadCapacity { get; }

    protected Container(string type, double maxLoad, double height, double depth, double ownWeight)
    {
        SerialNumber = $"KON-{type}-{Guid.NewGuid().ToString().Substring(0, 8)}";
        MaxLoadCapacity = maxLoad;
        Height = height;
        Depth = depth;
        OwnWeight = ownWeight;
    }

    public void UnloadCargo() => LoadMass = 0;


    public void LoadCargo(double mass)
    {
        if (LoadMass + mass > MaxLoadCapacity)
            throw new OverfillException("Masa ładunku jest większa niż maksymalna ładowność kontenera.");
        LoadMass += mass;
    }


    internal class OverfillException : InvalidOperationException
    {
        public OverfillException(string exception)
        {
            throw new NotImplementedException();
        }
    }
}