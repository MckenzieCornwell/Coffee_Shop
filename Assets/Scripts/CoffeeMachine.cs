using UnityEngine;
using System.Collections;

public class CoffeeMachine : MonoBehaviour
{
    [SerializeField] private Player player;

    public Items storing = Items.None;

    private bool making = false;

    private int waitTime = 3;

    private Items result;

    void OnMouseDown()
    {
        if (storing == Items.None)
        {
            switch (player.holding)
            {
                case Items.Cup:
                    StartCoroutine(CoffeeTimer(waitTime, Items.Espresso));
                    break;
                case Items.Hot_Water:
                    StartCoroutine(CoffeeTimer(waitTime, Items.Americano));
                    break;
                case Items.Milk:
                    StartCoroutine(CoffeeTimer(waitTime, Items.Cappuccino));
                    break;
                case Items.None:
                    Debug.Log("I need a cup");
                    break;
                default:
                    Debug.Log("This already has coffee in it");
                    break;
            }
        }
        else
        {
            if (player.holding == Items.None)
            {
                if (making == false)
                {
                    player.holding = storing;
                    storing = Items.None;
                    Debug.Log("Got " + player.holding);
                }
                else
                {
                    Debug.Log("The coffee machine is running");
                }
            }
            else
            {
                Debug.Log("I'm already holding something");
            }
        }
    }

    private IEnumerator CoffeeTimer(int waitTime, Items result)
    {
        storing = player.holding;
        player.holding = Items.None;
        making = true;
        Debug.Log("Making Coffee");

        yield return new WaitForSeconds(waitTime);

        making = false;
        storing = result;
        Debug.Log("Coffee is now ready");
    }
}
