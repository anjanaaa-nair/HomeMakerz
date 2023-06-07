using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class DisplayProductInfo : MonoBehaviour
{
    public GameObject UserInfoContainer;
    public GameObject UserInfoTemplate; 

    public TMP_Text pid;
    string imageString = "";

    // Start is called before the first frame update
    public void Display()
    {
        //StartCoroutine(GetRequest("http://localhost/HomeMakerz/ProductData.php"));
        StartCoroutine(GetRequest("https://homemakerz.000webhostapp.com/ProductData.php"));
    }


    IEnumerator GetRequest(string uri)
    {
        string id = pid.text;
        WWWForm form = new WWWForm();
        form.AddField("id", id);
        using (UnityWebRequest webRequest = UnityWebRequest.Post(uri, form))
        {
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();

            string[] pages = uri.Split('/');
            int page = pages.Length - 1;

            switch (webRequest.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.DataProcessingError:
                    Debug.LogError(pages[page] + ": Error: " + webRequest.error);
                    break;
                case UnityWebRequest.Result.ProtocolError:
                    Debug.LogError(pages[page] + ": HTTP Error: " + webRequest.error);
                    break;
                case UnityWebRequest.Result.Success:
                    //Debug.Log(pages[page] + ":\nReceived: " + webRequest.downloadHandler.text);
                    
                    string rawresponse = webRequest.downloadHandler.text;

                    string[] users = rawresponse.Split('*');

                    for(int i = 0; i < users.Length; i++)
                    {
                        //Debug.Log("Current data: " + users[i]);
                        if(users[i] != "")
                        {
                            string[] userinfo = users[i].Split(',');
                            Debug.Log("ID: " + userinfo[0] + "Name : " + userinfo[1] + "Price : " + userinfo[2] + "Description : " + userinfo[3]);
                            //Debug.Log("Name : " + userinfo[0] + userinfo[1] );
                            
                            imageString = userinfo[4];

                            byte[] Bytes = System.Convert.FromBase64String(imageString);
                            
                            Texture2D texture = new Texture2D(1,1);
                            texture.LoadImage(Bytes);
                            texture.Apply();
                            

                            GameObject gobj = (GameObject)Instantiate(UserInfoTemplate);
                            gobj.transform.SetParent(UserInfoContainer.transform);
                            
                            Sprite imgSprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));

                            gobj.GetComponent<RoomInfo>().image.sprite = imgSprite;                            
                            gobj.GetComponent<ProductDescriptionInfo>().id.text = userinfo[0];
                            gobj.GetComponent<ProductDescriptionInfo>().productName.text = userinfo[1];    
                            gobj.GetComponent<ProductDescriptionInfo>().price.text = userinfo[2];  
                            gobj.GetComponent<ProductDescriptionInfo>().description.text = userinfo[3];                                                       
                                                     
                        }
                    }

                    break;
            }
        }
    }
}
