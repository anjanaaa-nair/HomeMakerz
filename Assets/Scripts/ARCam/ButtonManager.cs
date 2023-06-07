using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.EventSystems;
using UnityEngine.XR.ARCore;
//using UnityEngine.XR.OpenXR;
//using DG.Tweening;





namespace UnityEngine.XR.ARFoundation
{

public class ButtonManager : MonoBehaviour
{
    private Button btn;
    public GameObject furniture;

    //[SerializeField]private RawImage buttonImage;

   /* private int _productId;

    private Sprite _buttonTexture;

    public Sprite ButtonTexture
     {
        set
        { 
        _buttonTexture = value; 
        
         buttonImage.texture =_buttonTexture.texture;

        }
        
        
     }
    
    public int ProductId 
    {
        set => _productId =value;
    }*/
       

     /*  public ButtonManager(GameObject furniture)
    {
        this.furniture = furniture;
    }*/

    // Start is called before the first frame update
    

    void Start()
    {
        
        btn = GetComponent<Button>();
        btn.onClick.AddListener(SelectObject);
    }


    /*void update()
    /*{
       if(UIManager.Instance.OnEntered(gameObject))
       {
        transform.DOScale(Vector3.one * 2,0.2f);
       // transform.localScale = Vector3.one * 2;
       }
       else
       {
        transform.DOScale(Vector3.one,0.2f);
        // transform.localScale = Vector3.one;

       }    }*/

    

    // Update is called once per frame
    void SelectObject()
    {
        
        DataHandler.Instance.furniture=furniture;


    }
}
}

