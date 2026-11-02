using UnityEngine;

public class Kettle : MonoBehaviour
{
    [SerializeField] private Player player;

    void OnMouseDown()
    {
        switch (player.holding)
        {
            case Items.Espresso:
                player.pickUp(Items.Americano);
                break;
            case Items.Cup:
                player.pickUp(Items.Water);
                break;
            default:
                player.textUpdate("I can mix this hot water with an Espresso for an Americano");
                break;
        }
    }
}
