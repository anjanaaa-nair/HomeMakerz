using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    public void Chair()
    {
        SceneManager.LoadScene("Chair");
    }
    public void Sofa()
    {
        SceneManager.LoadScene("Sofa");
    }
    public void Bed()
    {
        SceneManager.LoadScene("Bed");
    }
    public void CoffeeTable()
    {
        SceneManager.LoadScene("CoffeeTable");
    }
    public void DiningTable()
    {
        SceneManager.LoadScene("DiningTable");
    }
    public void Cabinet()
    {
        SceneManager.LoadScene("Cabinet");
    }
    public void Clock()
    {
        SceneManager.LoadScene("Clock");
    }
    public void Mirror()
    {
        SceneManager.LoadScene("Mirror");
    }
    public void Decor()
    {
        SceneManager.LoadScene("Decor");
    }
    public void Lamp()
    {
        SceneManager.LoadScene("Lamp");
    }
    public void back()
    {
        SceneManager.LoadScene("Home");
    }
}
