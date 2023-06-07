using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using TMPro;

public class OrderDB : MonoBehaviour
{
    public GameObject UserInfoContainer;
    public GameObject UserInfoTemplate; 
    //string imageString = "";

    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(GetRequest("http://localhost/HomeMakerz/GetOrderItems.php"));
        StartCoroutine(GetRequest("https://homemakerz.000webhostapp.com/GetOrderItems.php"));
   }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator GetRequest(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
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
                            Debug.Log("ProductName: " + userinfo[0] + "Description : " + userinfo[1] + "Price : " + userinfo[2]);
                            
                            /*
                            imageString = userinfo[1];

                            byte[] Bytes = System.Convert.FromBase64String(imageString);
                            
                            Texture2D texture = new Texture2D(1,1);
                            texture.LoadImage(Bytes);
                            texture.Apply();
                            */

                            GameObject gobj = (GameObject)Instantiate(UserInfoTemplate);
                            gobj.transform.SetParent(UserInfoContainer.transform);
                            
                            //Sprite imgSprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));

                            //gobj.GetComponent<RoomInfo>().image.sprite = imgSprite;                            
                            gobj.GetComponent<OrderInfo>().productName.text = userinfo[0];
                            gobj.GetComponent<OrderInfo>().description.text = userinfo[1];    
                            gobj.GetComponent<OrderInfo>().price.text = userinfo[2];                            
                        
                        }
                    }

                    break;
            }
        }
    }
}