using UnityEngine;

public class Coffee : MonoBehaviour
{
    bool coffeeMachineOn=false;

    void Start()
    {
        if (coffeeMachineOn)
        {
            Debug.Log("Brewing Coffee...");
        }
        else
        {
            Debug.Log("Out of Coffee Beans!");
        }
    }
}
