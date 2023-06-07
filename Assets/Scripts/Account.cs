using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using TMPro;
using UnityEngine.SceneManagement;

public class Account : MonoBehaviour
{
    public static Account instance;
    public TMP_InputField accountName;
    public TMP_InputField accountEmail;
    public TMP_InputField accountContact;
    public TMP_InputField accountUserName;
    public TMP_InputField accountPassword;
    public TMP_Text info;
    public string currentUsername;
    private string ukey = "accountusername" ;

    void Start()
    {
        instance = this;
        DontDestroyOnLoad(this.gameObject);
        currentUsername = "";
        if(PlayerPrefs.HasKey(ukey))
        {
            if(PlayerPrefs.GetString(ukey) != "")
            {
                currentUsername = PlayerPrefs.GetString(ukey);
                info.text = "You are logged in as " + currentUsername;
            }
            else
            {
                info.text = "You are not logged in";
            }
        }
        else
        {
            info.text = "You are not logged in";
        }
    }

    public void AccountLogout()
    {
        currentUsername = "";
        PlayerPrefs.SetString(ukey, currentUsername);
        //info.text = "You are just logged out";
        SceneManager.LoadScene("Initial");
    }

    public void AccountRegister()
    {
        string Name = accountName.text;
        string Email = accountEmail.text;
        string Contact = accountContact.text;
        string uName = accountUserName.text;
        string pWord = accountPassword.text;
        StartCoroutine(RegisterNewAccount(Name, Email, Contact, uName, pWord));
    }

    public void AccountLogin()
    {
        string uName = accountUserName.text;
        string pWord = accountPassword.text;
        StartCoroutine(LoginAccount(uName, pWord));
    }

    public IEnumerator RegisterNewAccount(string Name, string Email, string Contact, string uName, string pWord)
    {
        WWWForm form = new WWWForm();
        form.AddField("loginName", Name);
        form.AddField("loginEmail", Email);
        form.AddField("loginContact", Contact);
        form.AddField("loginUser", uName);
        form.AddField("loginPass", pWord);
        using (UnityWebRequest www = UnityWebRequest.Post("https://homemakerz.000webhostapp.com/RegisterUser.php", form))
        {
            www.downloadHandler = new DownloadHandlerBuffer();
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
            }
            else
            {
                string responseText = www.downloadHandler.text;
                Debug.Log("Response = " + responseText);
                //info.text = "Response = " + responseText;

            }
        }
    }
    
    public IEnumerator LoginAccount(string uName, string pWord)
    {
        WWWForm form = new WWWForm();
        form.AddField("loginUser", uName);
        form.AddField("loginPass", pWord);
        using (UnityWebRequest www = UnityWebRequest.Post("https://homemakerz.000webhostapp.com/Login.php", form))
        {
            www.downloadHandler = new DownloadHandlerBuffer();
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
            }
            else
            {
                string responseText = www.downloadHandler.text;
                if(responseText == "1")
                {
                    PlayerPrefs.SetString(ukey, uName);
                    //info.text = "Login success with username " + uName;
                    SceneManager.LoadSceneAsync("Home");
                }
                else
                {
                    info.text = "Login failed";
                }
            }
        }
    }
} 