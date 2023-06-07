using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class OrderMain : MonoBehaviour
{
    public void MoveToCheckout()
    {
        StartCoroutine(Checkout());
    }

    /*
    public void CancelOrder()
    {
        StartCoroutine(Cancel());
    }
    */

    IEnumerator Checkout()
    {
        WWWForm form = new WWWForm();

        //UnityWebRequest www = UnityWebRequest.Post("http://localhost/HomeMakerz/GetCartID.php", form);
        UnityWebRequest www = UnityWebRequest.Post("https://homemakerz.000webhostapp.com/GetCartID.php", form);
        
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

/*
    IEnumerator Cancel()
    {
        WWWForm form = new WWWForm();

        UnityWebRequest www = UnityWebRequest.Post("http://localhost/HomeMakerz/CancelOrder.php", form);
        
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
*/
}