using UnityEngine;

public enum Allergies
{
    Milk,
    Gluten
}

[CreateAssetMenu(fileName = "NewIngredients", menuName = "Game/Ingredients")]

public class Ingredients : ScriptableObject
{
    public float price;
    public float quantity;
    public float quantityAvailableInShop;
    public bool inStock;
    public Allergies[] allergies;
}
