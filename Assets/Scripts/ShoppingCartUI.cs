using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShoppingCartUI : MonoBehaviour
{
    public TMP_Text cartText;
    public ShoppingCart cart;

    public void Start()
    {
        cart = FindObjectOfType<ShoppingCart>();
    }

    public void Update()
    {
        string cartString = "Cart:\n";
        //string cartString = "Sofa";

        foreach (KeyValuePair<string, int> item in cart.GetItems())
        {
            cartString += item.Key + " x " + item.Value + " - $" + (item.Value * GetPrice(item.Key)) + "\n";
        }

        cartText.text = cartString;
    }

    public int GetPrice(string itemName)
    {
        ShopItem[] shopItems = FindObjectsOfType<ShopItem>();

        foreach (ShopItem item in shopItems)
        {
            if (item.itemName == itemName)
            {
                return item.price;
            }
        }

        return 0;
    }
}