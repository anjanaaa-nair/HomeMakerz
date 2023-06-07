using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using TMPro;
using UnityEngine.SceneManagement;

public class GetProduct : MonoBehaviour
{
    public static GetProduct Instance;
    public GameObject HomePanel;


    public GameObject SearchPanel;

    public void Search()
    {
        Instance = this;
        HomePanel.SetActive(false);
        SearchPanel.SetActive(true);
    }


    public GameObject LivingRoom;
    public GameObject DiningRoom;
    public GameObject BedRoom;
    public GameObject OfficeRoom;
    public GameObject Balcony;
    public GameObject Kitchen;
    public GameObject BathRoom;
    public GameObject LaundryRoom;
    public GameObject ClosetRoom;
    public GameObject Library;

    public void livingRoom()
    {
        Instance = this;
        HomePanel.SetActive(false);
        LivingRoom.SetActive(true);
    }

    public void diningRoom()
    {
        Instance = this;
        HomePanel.SetActive(false);
        DiningRoom.SetActive(true);
    }

    public void bedRoom()
    {
        Instance = this;
        HomePanel.SetActive(false);
        BedRoom.SetActive(true);
    }

    public void officeRoom()
    {
        Instance = this;
        HomePanel.SetActive(false);
        OfficeRoom.SetActive(true);
    }

    public void balcony()
    {
        Instance = this;
        HomePanel.SetActive(false);
        Balcony.SetActive(true);
    }

    public void kitchen()
    {
        Instance = this;
        HomePanel.SetActive(false);
        Kitchen.SetActive(true);
    }

    public void bathroom()
    {
        Instance = this;
        HomePanel.SetActive(false);
        BathRoom.SetActive(true);
    }

    public void laundryRoom()
    {
        Instance = this;
        HomePanel.SetActive(false);
        LaundryRoom.SetActive(true);
    }

    public void closetRoom()
    {
        Instance = this;
        HomePanel.SetActive(false);
        ClosetRoom.SetActive(true);
    }

    public void library()
    {
        Instance = this;
        HomePanel.SetActive(false);
        Library.SetActive(true);
    }

    public GameObject SofaPanel;
    public GameObject ChairPanel;
    public GameObject CabinetPanel;
    public GameObject BedPanel;
    public GameObject ClockPanel;
    public GameObject TablePanel;
    public GameObject DecorPanel;
    public GameObject MirrorPanel;
    public GameObject LampPanel;
    public GameObject CoffeePanel;


    public GetBed getBed;
    public GetCabinet getCabinet;
    public GetChair getChair;
    public GetClock getClock;
    public GetCoffee getCoffee;
    public GetDecor getDecor;
    public GetLamp getLamp;
    public GetMirror getMirror;
    public GetSofa getSofa;
    public GetTable getTable;

    
    public void Sofa()
    {
        Instance = this;
        HomePanel.SetActive(false);
        SofaPanel.SetActive(true);
        getSofa = GetComponent<GetSofa>();
    }

    public void Chair()
    {
        Instance = this;
        HomePanel.SetActive(false);
        ChairPanel.SetActive(true);
        getChair = GetComponent<GetChair>();
    }

    public void Cabinet()
    {
        Instance = this;
        HomePanel.SetActive(false);
        CabinetPanel.SetActive(true);
        getCabinet = GetComponent<GetCabinet>();
    }

    public void Bed()
    {
        Instance = this;
        HomePanel.SetActive(false);
        BedPanel.SetActive(true);
        getBed = GetComponent<GetBed>();
    }

    public void Clock()
    {
        Instance = this;
        HomePanel.SetActive(false);
        ClockPanel.SetActive(true);
        getClock = GetComponent<GetClock>();
    }

    public void Table()
    {
        Instance = this;
        HomePanel.SetActive(false);
        TablePanel.SetActive(true);
        getTable = GetComponent<GetTable>();
    }

    public void Decor()
    {
        Instance = this;
        HomePanel.SetActive(false);
        DecorPanel.SetActive(true);
        getDecor = GetComponent<GetDecor>();
    }

    public void Mirror()
    {
        Instance = this;
        HomePanel.SetActive(false);
        MirrorPanel.SetActive(true);
        getMirror = GetComponent<GetMirror>();
    }

    public void Lamp()
    {
        Instance = this;
        HomePanel.SetActive(false);
        LampPanel.SetActive(true);
        getLamp = GetComponent<GetLamp>();
    }

    public void Coffee()
    {
        Instance = this;
        HomePanel.SetActive(false);
        CoffeePanel.SetActive(true);
        getCoffee = GetComponent<GetCoffee>();
    }

    public void Back()
    {
        Instance = this;
        SearchPanel.SetActive(false);
        SofaPanel.SetActive(false);
        ChairPanel.SetActive(false);
        CabinetPanel.SetActive(false);
        BedPanel.SetActive(false);
        ClockPanel.SetActive(false);
        TablePanel.SetActive(false);
        DecorPanel.SetActive(false);
        MirrorPanel.SetActive(false);
        LampPanel.SetActive(false);
        CoffeePanel.SetActive(false);
        LivingRoom.SetActive(false);
        DiningRoom.SetActive(false);
        BedRoom.SetActive(false);
        OfficeRoom.SetActive(false);
        Balcony.SetActive(false);
        Kitchen.SetActive(false);
        BathRoom.SetActive(false);
        LaundryRoom.SetActive(false);
        ClosetRoom.SetActive(false);
        Library.SetActive(false);
        HomePanel.SetActive(true);
    }

    public void backToSofa()
    {
        Instance = this;
        SearchPanel.SetActive(false);
        SofaPanel.SetActive(true);
        ChairPanel.SetActive(false);
        CabinetPanel.SetActive(false);
        BedPanel.SetActive(false);
        ClockPanel.SetActive(false);
        TablePanel.SetActive(false);
        DecorPanel.SetActive(false);
        MirrorPanel.SetActive(false);
        LampPanel.SetActive(false);
        CoffeePanel.SetActive(false);
        LivingRoom.SetActive(false);
        DiningRoom.SetActive(false);
        BedRoom.SetActive(false);
        OfficeRoom.SetActive(false);
        Balcony.SetActive(false);
        Kitchen.SetActive(false);
        BathRoom.SetActive(false);
        LaundryRoom.SetActive(false);
        ClosetRoom.SetActive(false);
        Library.SetActive(false);
        HomePanel.SetActive(false);
    }

    public void backToChair()
    {
        Instance = this;
        SearchPanel.SetActive(false);
        SofaPanel.SetActive(false);
        ChairPanel.SetActive(true);
        CabinetPanel.SetActive(false);
        BedPanel.SetActive(false);
        ClockPanel.SetActive(false);
        TablePanel.SetActive(false);
        DecorPanel.SetActive(false);
        MirrorPanel.SetActive(false);
        LampPanel.SetActive(false);
        CoffeePanel.SetActive(false);
        LivingRoom.SetActive(false);
        DiningRoom.SetActive(false);
        BedRoom.SetActive(false);
        OfficeRoom.SetActive(false);
        Balcony.SetActive(false);
        Kitchen.SetActive(false);
        BathRoom.SetActive(false);
        LaundryRoom.SetActive(false);
        ClosetRoom.SetActive(false);
        Library.SetActive(false);
        HomePanel.SetActive(false);
    }
    public void backToTable()
    {
        Instance = this;
        SearchPanel.SetActive(false);
        SofaPanel.SetActive(false);
        ChairPanel.SetActive(false);
        CabinetPanel.SetActive(false);
        BedPanel.SetActive(false);
        ClockPanel.SetActive(false);
        TablePanel.SetActive(true);
        DecorPanel.SetActive(false);
        MirrorPanel.SetActive(false);
        LampPanel.SetActive(false);
        CoffeePanel.SetActive(false);
        LivingRoom.SetActive(false);
        DiningRoom.SetActive(false);
        BedRoom.SetActive(false);
        OfficeRoom.SetActive(false);
        Balcony.SetActive(false);
        Kitchen.SetActive(false);
        BathRoom.SetActive(false);
        LaundryRoom.SetActive(false);
        ClosetRoom.SetActive(false);
        Library.SetActive(false);
        HomePanel.SetActive(false);
    }

    public void backToCoffee()
    {
        Instance = this;
        SearchPanel.SetActive(false);
        SofaPanel.SetActive(false);
        ChairPanel.SetActive(false);
        CabinetPanel.SetActive(false);
        BedPanel.SetActive(false);
        ClockPanel.SetActive(false);
        TablePanel.SetActive(false);
        DecorPanel.SetActive(false);
        MirrorPanel.SetActive(false);
        LampPanel.SetActive(false);
        CoffeePanel.SetActive(true);
        LivingRoom.SetActive(false);
        DiningRoom.SetActive(false);
        BedRoom.SetActive(false);
        OfficeRoom.SetActive(false);
        Balcony.SetActive(false);
        Kitchen.SetActive(false);
        BathRoom.SetActive(false);
        LaundryRoom.SetActive(false);
        ClosetRoom.SetActive(false);
        Library.SetActive(false);
        HomePanel.SetActive(false);
    }

    public void backToBed()
    {
        Instance = this;
        SearchPanel.SetActive(false);
        SofaPanel.SetActive(false);
        ChairPanel.SetActive(false);
        CabinetPanel.SetActive(false);
        BedPanel.SetActive(true);
        ClockPanel.SetActive(false);
        TablePanel.SetActive(false);
        DecorPanel.SetActive(false);
        MirrorPanel.SetActive(false);
        LampPanel.SetActive(false);
        CoffeePanel.SetActive(false);
        LivingRoom.SetActive(false);
        DiningRoom.SetActive(false);
        BedRoom.SetActive(false);
        OfficeRoom.SetActive(false);
        Balcony.SetActive(false);
        Kitchen.SetActive(false);
        BathRoom.SetActive(false);
        LaundryRoom.SetActive(false);
        ClosetRoom.SetActive(false);
        Library.SetActive(false);
        HomePanel.SetActive(false);
    }
}
