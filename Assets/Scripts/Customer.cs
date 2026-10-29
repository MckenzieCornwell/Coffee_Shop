using UnityEngine;

public class Customer : MonoBehaviour
{
    [SerializeField] private Player player;

    public Items order = Items.Cappuccino;

    private int totalCustomers = 3;

    private bool beenServed = false;

    void OnMouseDown()
    {
        if (beenServed == false)
        {
            if (player.holding == order)
            {
                player.holding = Items.None;
                Debug.Log("Gave customer their order");
                beenServed = true;
                player.customersServed += 1;

                if (player.customersServed >= totalCustomers)
                {
                    Debug.Log("All customers served");
                }
            }
            else if (player.holding == Items.None)
            {
                Debug.Log("I would like a " + order);
            }
            else
            {
                Debug.Log("That's not my order");
            }
        }
        else
        {
            Debug.Log("I've already served this customer");
        }
    }
}
