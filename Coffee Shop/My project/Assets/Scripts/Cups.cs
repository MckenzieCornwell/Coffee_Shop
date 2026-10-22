using UnityEngine;

public class Cups : MonoBehaviour
{
    private int beans=5;
    private int refills=3;
    private string[] coffeeMenu = {"Espresso", "Latte", "Mocha"};

    void Start()
    {
        for (int i=1; i<=10; i++)
        {
            Debug.Log("There are now "+ i +" coffee cups on the counter.");
        }

        while (beans>0)
        {
            Debug.Log("A cup was served. There are "+ beans +" beans left.");
            beans--;
        }

        do
        {
            Debug.Log("The customer got a refill.");
            refills--;
        }
        while (refills>0);

        
        foreach (string item in coffeeMenu)
        {
            Debug.Log(item +" is on the menu.");
        }
    }
}
