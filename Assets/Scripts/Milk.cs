using UnityEngine;

public class Milk : MonoBehaviour
{
    [SerializeField] private Player player;

    void OnMouseDown()
    {
        switch (player.holding)
        {
            case Items.Espresso:
                player.pickUp(Items.Cappuccino);
                break;
            case Items.Cappuccino:
                player.pickUp(Items.Latte);
                break;
            case Items.Cup:
                player.pickUp(Items.Milk);
                break;
            default:
                player.textUpdate("I can mix this milk with an Espresso for a Cappuccino or Latte");
                break;
        }
    }
}
