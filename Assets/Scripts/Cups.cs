using UnityEngine;

public class Cups : MonoBehaviour
{
    [SerializeField] private Player player;

    void OnMouseDown()
    {
        if (player.holding == Items.None)
        {
            player.pickUp(Items.Cup);
        }
        else
        {
            player.textUpdate("I'm already holding something");
        }
    }
}
