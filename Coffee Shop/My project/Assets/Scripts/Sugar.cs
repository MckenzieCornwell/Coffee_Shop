using UnityEngine;

public class Sugar : MonoBehaviour
{
    int sugarLevel=0;

    void Start()
    {
        if (sugarLevel==1)
        {
            Debug.Log("Coffee with 1 spoon of sugar.");
        }
        else if (sugarLevel==2)
        {
            Debug.Log("Coffee with 2 spoons of sugar.");
        }
        else if (sugarLevel==3)
        {
            Debug.Log("Coffee extra sweet with 3 spoons of sugar!");
        }
        else
        {
            Debug.Log("Black coffee, no sugar.");
        }
    }
}
