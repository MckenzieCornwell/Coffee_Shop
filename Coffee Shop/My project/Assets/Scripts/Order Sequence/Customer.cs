using UnityEngine;
using UnityEngine.Events;

public class Customer : MonoBehaviour
{
    //variables
    public readonly static string drinkType="Coffee";
    //static means that it is per class, and not per instance of a class

    public UnityEvent raiseOrder;

    void Start()
    {
        RequestDrink(drinkType);
    }

    void RequestDrink(string drinkType)
    {
        Debug.Log(drinkType);
        raiseOrder?.Invoke();
    }
}