using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using TMPro;
using UnityEngine.SceneManagement;

public class RoomsProducts : MonoBehaviour
{
    public static RoomsProducts Instance;
    public GameObject HomePanel;
    public GameObject ProductDetailsPanel;
    public GameObject RoomPanel;

    public GetRoomData getRoomData;
    public GetProductData getProductData;

    public void Product()
    {
        Instance = this;
        HomePanel.SetActive(false);
        ProductDetailsPanel.SetActive(true);
        getProductData = GetComponent<GetProductData>();
    }

    public void Room()
    {
        Instance = this;
        HomePanel.SetActive(false);
        RoomPanel.SetActive(true);
        getRoomData = GetComponent<GetRoomData>();
    }

    public void Back()
    {
        Instance = this;
        ProductDetailsPanel.SetActive(false);
        RoomPanel.SetActive(false);
        HomePanel.SetActive(true);
    }
}
