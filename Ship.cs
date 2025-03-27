namespace ConsoleApp1;

class Ship
{
    public List<Container> Containers { get; } = new();
    public double MaxSpeed { get; }
    public int MaxContainerCount { get; }
    public double MaxWeightCapacity { get; }

    public Ship(double maxWeight, int maxContainers, double maxSpeed)
    {
        MaxWeightCapacity = maxWeight;
        MaxContainerCount = maxContainers;
        MaxSpeed = maxSpeed;
    }

    public void LoadContainer(Container container)
    {
        if (Containers.Count >= MaxContainerCount || TotalLoadWeight() + container.OwnWeight > MaxWeightCapacity)
            throw new InvalidOperationException("Statek jest przeciążony");
        Containers.Add(container);
    }

    public void UnloadContainer(string serialNumber) => Containers.RemoveAll(c => c.SerialNumber == serialNumber);

    public double TotalLoadWeight() => Containers.Sum(c => c.OwnWeight + c.LoadMass);
}