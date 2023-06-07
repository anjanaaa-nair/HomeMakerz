using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.Networking;

public class StoreUserData : MonoBehaviour
{
    public TMP_InputField inputField;

    public void SendInputData() 
    {
        //string inputData = inputField.text;
        //StartCoroutine(PostInputData(inputData));
        StartCoroutine(PostInputData());

    }

    IEnumerator PostInputData() 
    {
        string inputData = inputField.text;
        WWWForm form = new WWWForm();
        form.AddField("inputData", inputData);

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
            /*
            yield return www;
            if (!string.IsNullOrEmpty(www.error)) 
            {
                Debug.LogError(www.error);
            }
            */
        
    }
}

