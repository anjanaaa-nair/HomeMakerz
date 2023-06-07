using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopItem : MonoBehaviour
{
    public string itemName;
    public int price;

    public void AddToCart()
    {
        ShoppingCart cart = FindObjectOfType<ShoppingCart>();
        cart.AddItem(itemName, 1);
    }
}
