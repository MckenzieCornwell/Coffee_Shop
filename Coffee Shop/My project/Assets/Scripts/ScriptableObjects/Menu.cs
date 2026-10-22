using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "NewCoffeeShopMenu", menuName = "Game/Coffee Shop Menu")]

public class CoffeeShopMenu : ScriptableObject
{
    public enum CoffeeType
    {
        Espresso,
        Latte,
        Cappuccino,
        Americano,
        Mocha,
        None
    }
}
