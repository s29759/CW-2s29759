namespace ConsoleApp1;
using System;
using System.Collections.Generic;
class RefrigeratedContainer : Container
{
    public double RequiredTemperature { get; }

    private static Dictionary<string, double> Temperatures = new()
    {
        {"Banany", 13.3}, {"Czekolada", 18}, {"Ryby", 2}, {"Mięso", -15}, {"Lody", -18}, {"Pizza mrożona", -30}, {"Ser", 7.2}, {"Kiełbasy" , 5}, {"Masło" , 20.5}, {"Jajka" , 19}

    };

    public RefrigeratedContainer(double maxLoad, double height, double depth, double ownWeight, double temperature)
        : base("C", maxLoad, height, depth, ownWeight)
    {
        RequiredTemperature = temperature;
    }

    public bool isTemperature(string product)
    {
        return Temperatures.ContainsKey(product) && RequiredTemperature>= Temperatures[product];
    }
}