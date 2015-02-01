using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class HelpManager : MonoBehaviour
{
    public static List<Help> helps = new List<Help>();


    void Start()
    {
        helps.Add(new Help("Nižje povpraševanje", "In economics, demand is the utility for a good or service of an economic agent, relative to his/her income. (Note: This distinguishes demand from quantity demanded, where demand is a listing or graphing of quantity demanded at each possible price. In contrast to demand, quantity demanded is the exact quantity demanded at a certain price. Changing the actual price will change the quantity demanded, but it will not change the demand, because demand is a listing of quantities that would be bought at various prices, not just the actual price.) Demand is a buyer's willingness and ability to pay a price for a specific quantity of a good or service. Demand refers to how much (quantity) of a product or service is desired by buyers at various prices. The quantity demanded is the amount of a product people are willing to buy at a certain price; the relationship between price and quantity demanded is known as the demand.[1] (see also supply and demand). The term demand signifies the ability or the willingness to buy a particular commodity at a given point of time."));
		helps.Add(new Help("Višje povpraševanje", "Pour-over mixtape viral, freegan wolf artisan Etsy farm-to-table 90's VHS messenger bag sriracha fixie occupy flexitarian. Biodiesel direct trade fixie sartorial, mlkshk readymade vinyl gastropub you probably haven't heard of them pork belly cred banh mi. Locavore quinoa mumblecore mixtape. Hella freegan wolf chambray iPhone Thundercats, taxidermy small batch fingerstache stumptown High Life photo booth kitsch. +1 cornhole chia ennui street art. Ennui farm-to-table quinoa listicle. Umami cliche Thundercats, fingerstache try-hard Tonx drinking vinegar scenester Intelligentsia."));
    }

    public enum HelpType
    {
        lowerDemand = 0,
		higherDemand = 1
    }
}
