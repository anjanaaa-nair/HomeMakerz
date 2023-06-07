using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class GetProductData : MonoBehaviour
{
     public TMP_Text pid;

    public void DisplayDetails()
    {
        StartCoroutine(Details());
    }

    public IEnumerator Details()
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
}

