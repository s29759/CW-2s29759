using System;
using ConsoleApp1;

class Program
{
    static void Main()
    {
        Ship ship = new(100000, 50, 30);
        LiquidContainer liquidContainer = new(5000, 250, 100, 200, true);
        GasContainer gasContainer = new(30000, 270, 200, 180, 2);
        ship.LoadContainer(liquidContainer);
        ship.LoadContainer(gasContainer);
        ship.UnloadContainer(liquidContainer.SerialNumber);
        
    }
}