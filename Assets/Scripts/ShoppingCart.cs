using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoppingCart : MonoBehaviour
{
    private Dictionary<string, int> cartItems = new Dictionary<string, int>();

    public void AddItem(string itemName, int quantity)
    {
        if (cartItems.ContainsKey(itemName))
        {
            cartItems[itemName] += quantity;
        }
        else
        {
            cartItems.Add(itemName, quantity);
        }
    }

    public void RemoveItem(string itemName, int quantity)
    {
        if (cartItems.ContainsKey(itemName))
        {
            cartItems[itemName] -= quantity;

            if (cartItems[itemName] <= 0)
            {
                cartItems.Remove(itemName);
            }
        }
    }

    public void ClearCart()
    {
        cartItems.Clear();
    }

    public Dictionary<string, int> GetItems()
    {
        return cartItems;
    }
}