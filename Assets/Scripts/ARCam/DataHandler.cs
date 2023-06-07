using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.XR.ARCore;
//using UnityEngine.XR.OpenXR;
//using UnityEngine.AddressableAssets;
//using System.Threading.Tasks;


namespace UnityEngine.XR.ARFoundation
{


public class DataHandler : MonoBehaviour
{
   public GameObject furniture;

  // [SerializeField] private ButtonManager buttonPrefab;
   //[SerializeField] private GameObject buttonContainer;

   /*[SerializeField] private List<Product> _products;
   [SerializeField] private string label;

    private int id = 0;*/
   private static DataHandler instance;

   public static DataHandler Instance

    {
         get
            {
                if (instance == null)
                    {
                        instance = FindObjectOfType<DataHandler>();

                    }
                return instance;    
            }

    }

    /*private async void Start()
    {
        _products = new List<Product>();

        //LoadProducts();
        //await Get(label);
        CreateButtons();

    }
    /*void LoadProducts()
    {
        var products_obj=Resources.LoadAll("products",typeof(Product));
        foreach (var product  in products_obj)
        {
            _products.Add(product as Product);
        }
    }



    void CreateButtons()
    {
        foreach (Product p in _products)
        {
            ButtonManager b = Instantiate(buttonPrefab,buttonContainer.transform);
            b.ProductId=id;
            b.ButtonTexture = p.ProductImage;
            id++;
    
        }
    }*/

    /*public void SetFurniture(int id)
    {
        furniture = _products[id].productPrefab;
    }
    public GameObject GetFurniture()
    {
        return furniture;
    }

   /* public async Task Get(string label)
    {
      var locations =await Addressables.LoadResourceLocationsAsync(label).Task;
      foreach (var location in locations)
      {
        var obj = await Addressables.LoadAssetAsync<Product>(location).Task;
        _products.Add(obj);
      }

    }*/
    

}



}