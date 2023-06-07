using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class MyOrdersMain : MonoBehaviour
{
    public void PostPayment()
    {
        StartCoroutine(MyOrders());
    }

    /*
    public void CancelOrder()
    {
        StartCoroutine(Cancel());
    }
    */

    IEnumerator MyOrders()
    {
        WWWForm form = new WWWForm();

        //UnityWebRequest www = UnityWebRequest.Post("http://localhost/HomeMakerz/GetMyOrders.php", form);
        UnityWebRequest www = UnityWebRequest.Post("https://homemakerz.000webhostapp.com/GetMyOrders.php", form);
        
        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log(www.error);
        }
        else
        {
            Debug.Log("Text sent!");
        }
    }
}