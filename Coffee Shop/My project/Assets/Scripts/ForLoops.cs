using UnityEngine;

public class ForLoops : MonoBehaviour
{
    [SerializeField] private string[] coffeeMenu = { "Espresso", "Latte", "Mocha" };
    
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("Coffee Number: " + i);
        }

        foreach (string coffee in coffeeMenu)
        {
            Debug.Log("Now serving: " + coffee);
        }
    }
}
