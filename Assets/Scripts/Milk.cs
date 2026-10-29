using UnityEngine;

public class Milk : MonoBehaviour
{
    [SerializeField] private Player player;

    void OnMouseDown()
    {
        switch (player.holding)
        {
            case Items.Espresso:
                Debug.Log("Mixing milk with an Espresso");
                player.holding = Items.Cappuccino;
                Debug.Log("Got " + player.holding);
                break;
            case Items.Cappuccino:
                Debug.Log("Mixing milk with a Cappuccino");
                player.holding = Items.Latte;
                Debug.Log("Got " + player.holding);
                break;
            case Items.Cup:
                Debug.Log("Filling a cup with milk");
                player.holding = Items.Milk;
                Debug.Log("Got " + player.holding);
                break;
            default:
                Debug.Log("I can mix this milk with an Espresso for a Cappuccino or Latte");
                break;
        }
    }
}
