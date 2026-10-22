using UnityEngine;

public enum CoffeeType
{
    Espresso,
    Latte,
    Cappuccino,
    Americano
}

[CreateAssetMenu(fileName="CoffeeData", menuName="Coffee/Coffee Data")]
public class CoffeeData : ScriptableObject
{
    public float espressoPrice = 2.00f;
    public float lattePrice = 3.50f;
    public float cappuccinoPrice = 3.00f;
    public float americanoPrice = 2.50f;
}
