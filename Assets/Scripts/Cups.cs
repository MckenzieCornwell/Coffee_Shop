using UnityEngine;

public class Cups : MonoBehaviour
{
    [SerializeField] private Player player;

    void OnMouseDown()
    {
        if (player.holding == Items.None)
        {
            player.holding = Items.Cup;
            Debug.Log("Got " + player.holding);
        }
        else
        {
            Debug.Log("I'm already holding something");
        }
    }
}
