using UnityEngine;
using System.Collections;

public class Customer : MonoBehaviour
{
    [SerializeField] private Player player;

    public Items order;

    private int totalCustomers = 3;

    private bool beenServed = false;

    private float moveTime = 0.025F;

    void Start()
    {
        player.servedText.text = "Customers Served: " + player.customersServed + "/" + totalCustomers;
        StartCoroutine(NextCustomer(moveTime));
    }

    void OnMouseDown()
    {
        if (beenServed == false)
        {
            if (player.holding == order)
            {
                player.dropItem();
                player.textUpdate("Thanks for the coffee");
                beenServed = true;
                player.customersServed += 1;
                player.servedText.text = "Customers Served: " + player.customersServed + "/" + totalCustomers;

                StartCoroutine(CustomerLeave(moveTime));
            }
            else if (player.holding == Items.None || player.holding == Items.Cup)
            {
                player.orderText.text = "Order: " + order;
                player.textUpdate("I would like a " + order);
            }
            else
            {
                player.textUpdate("That's not my order");
            }
        }
        else
        {
            player.textUpdate("I've already served this customer");
        }
    }

    private IEnumerator CustomerLeave(float moveTime)
    {
        for (int i = 0; i < 30; i++)
        {
            transform.position += new Vector3(-0.1F, 0, 0);
            yield return new WaitForSeconds(moveTime);
        }

        StartCoroutine(NextCustomer(moveTime));
    }

    private IEnumerator NextCustomer(float moveTime)
    {
        if (player.customersServed >= totalCustomers)
        {
            player.textUpdate("All customers are served");
        }
        else
        {
            beenServed = false;
            order = (Items)Random.Range(0, 4);
            player.orderText.text = "Order: ???";

            for (int i = 0; i < 30; i++)
            {
                transform.position += new Vector3(0.1F, 0, 0);
                yield return new WaitForSeconds(moveTime);
            }
        }
    }
}
