namespace ConsoleApp1;

class LiquidContainer : Container, IHazardNotifier
{
    private bool IsHazardous { get; }

    public LiquidContainer(double maxLoad, double height, double depth, double ownWeight, bool isHazardous)
        : base("L", maxLoad, height, depth, ownWeight)
    {
        IsHazardous = isHazardous;
    }

    public new void LoadCargo(double mass)
    {
        double limit = IsHazardous ? 0.5 * MaxLoadCapacity : 0.9 * MaxLoadCapacity;
        if (mass > limit)
        {
            NotifyHazard("Próba wykonania niebezpiecznej operacji");
            return;
        }
    }
    

    public void NotifyHazard(string message) => Console.WriteLine($"{message} - Kontener o numerze{SerialNumber}");
}