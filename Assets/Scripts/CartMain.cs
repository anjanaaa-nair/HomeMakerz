using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class CartMain : MonoBehaviour
{
    public TMP_Text pid;
    //public TMP_Text pname;

    public void AddtoCart()
    {
        StartCoroutine(AddItem());
    }

    public void DeleteFromCart()
    {
        StartCoroutine(DeleteItem());
    }

    IEnumerator AddItem()
    {
        string id = pid.text;
        WWWForm form = new WWWForm();
        form.AddField("ID", id);

        //UnityWebRequest www = UnityWebRequest.Post("http://localhost/HomeMakerz/GetProductID.php", form);
        UnityWebRequest www = UnityWebRequest.Post("https://homemakerz.000webhostapp.com/GetProductID.php", form);
        
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

    IEnumerator DeleteItem()
    {
        string id = pid.text;
        //string name = pname.text;
        WWWForm form = new WWWForm();
        form.AddField("ID", id);
        //form.AddField("Name", name);

        //UnityWebRequest www = UnityWebRequest.Post("http://localhost/HomeMakerz/DeleteCartItem.php", form);
        UnityWebRequest www = UnityWebRequest.Post("https://homemakerz.000webhostapp.com/DeleteCartItem.php", form);
        
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