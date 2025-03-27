namespace ConsoleApp1;

class GasContainer : Container, IHazardNotifier
{
    public double Pressure { get; }

    public GasContainer(double maxLoad, double height, double depth, double ownWeight, double pressure)
        : base("G", maxLoad, height, depth, ownWeight)
    {
        Pressure = pressure;
    }

    public new void UnloadCargo()
    {
        LoadMass *= 0.05;
    }

    public void NotifyHazard(string message) => Console.WriteLine($"{message} - Kontener o numerze: {SerialNumber}");
}