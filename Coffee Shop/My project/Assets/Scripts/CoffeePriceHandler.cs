using UnityEngine;

public class CoffeePriceHandler : MonoBehaviour
{
    [SerializeField] private CoffeeData coffeeData;
    [SerializeField] private CoffeeType selectedCoffee;

    void Start()
    {
        float price = GetCoffeePrice(selectedCoffee);

        Debug.Log($"{selectedCoffee} costs £{price:F2}");
    }

    private float GetCoffeePrice(CoffeeType type)
    {
        switch (type)
        {
            case CoffeeType.Espresso:
                return coffeeData.espressoPrice;
            case CoffeeType.Latte:
                return coffeeData.lattePrice;
            case CoffeeType.Cappuccino:
                return coffeeData.cappuccinoPrice;
            case CoffeeType.Americano:
                return coffeeData.americanoPrice;
            default:
                return 0f;
        }
    }
}
