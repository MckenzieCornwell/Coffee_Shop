using UnityEngine;
using System.Collections;

public class CoffeeMachine : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private GameObject coffeeCup;

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
                case Items.Water:
                    StartCoroutine(CoffeeTimer(waitTime, Items.Americano));
                    break;
                case Items.Milk:
                    StartCoroutine(CoffeeTimer(waitTime, Items.Cappuccino));
                    break;
                case Items.None:
                    player.textUpdate("I need a cup for an Espresso");
                    break;
                default:
                    player.textUpdate("This already has coffee in it");
                    break;
            }
        }
        else
        {
            if (player.holding == Items.None)
            {
                if (making == false)
                {
                    player.pickUp(storing);
                    storing = Items.None;
                    coffeeCup.SetActive(false);
                }
                else
                {
                    player.textUpdate("The coffee machine is running");
                }
            }
            else
            {
                player.textUpdate("I'm already holding something");
            }
        }
    }

    private IEnumerator CoffeeTimer(int waitTime, Items result)
    {
        storing = player.holding;
        coffeeCup.SetActive(true);
        player.dropItem();
        making = true;
        player.textUpdate("Making Coffee");

        yield return new WaitForSeconds(waitTime);

        making = false;
        storing = result;
        player.textUpdate("Coffee is now ready");
    }
}
