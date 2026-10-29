using UnityEngine;

public class Kettle : MonoBehaviour
{
    [SerializeField] private Player player;

    void OnMouseDown()
    {
        switch (player.holding)
        {
            case Items.Espresso:
                Debug.Log("Mixing hot water with an Espresso");
                player.holding = Items.Americano;
                Debug.Log("Got " + player.holding);
                break;
            case Items.Cup:
                Debug.Log("Filling a cup with hot water");
                player.holding = Items.Hot_Water;
                Debug.Log("Got " + player.holding);
                break;
            default:
                Debug.Log("I can mix this hot water with an Espresso for an Americano");
                break;
        }
    }
}
