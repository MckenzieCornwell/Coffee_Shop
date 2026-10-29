using UnityEngine;

public class Bin : MonoBehaviour
{
    [SerializeField] private Player player;

    void OnMouseDown()
    {
        if (player.holding != Items.None)
        {
            Debug.Log("Threw " + player.holding + " away");
            player.holding = Items.None;
        }
        else
        {
            Debug.Log("I can throw something away here");
        }
    }
}
