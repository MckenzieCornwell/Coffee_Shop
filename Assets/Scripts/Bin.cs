using UnityEngine;

public class Bin : MonoBehaviour
{
    [SerializeField] private Player player;

    void OnMouseDown()
    {
        if (player.holding != Items.None)
        {
            player.textUpdate("Threw " + player.holding + " away");
            player.dropItem();
        }
        else
        {
            player.textUpdate("I can throw something away here");
        }
    }
}
