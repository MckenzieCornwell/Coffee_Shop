using UnityEngine;

public enum Items
{
    Espresso,
    Latte,
    Cappuccino,
    Americano,
    Hot_Water,
    Milk,
    Cup,
    None
}

public class Player : MonoBehaviour
{
    public Items holding = Items.None;

    public int customersServed = 0;
}
