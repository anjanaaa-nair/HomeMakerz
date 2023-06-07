using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.EventSystems;
//using UnityEngine.XR.OpenXR;
using UnityEngine.XR.ARCore;
//using UnityEngine.XR.Interaction.Toolkit.AR;




namespace UnityEngine.XR.ARFoundation
{


public class InputManager : MonoBehaviour
{
    //[SerializeField] private GameObject arObj;

    [SerializeField] private Camera arCam;

    [SerializeField] private ARRaycastManager _raycastManager;

    [SerializeField] private GameObject crosshair;
    private List<ARRaycastHit> _hits = new List<ARRaycastHit>();

    private Touch touch;
    private Pose pose;




    // Start is called before the first frame update
    void Start()
    {
    
    }


    /*protected override bool CanStartManipulationForGesture(TapGesture gesture)
        {
            if(gesture.targetObject==null)
            return true;
          return false;  
        }

    protected override void  OnEndManipulation(TapGesture gesture)
    {
        if(gesture.isCanceled)
        return;
        if(gesture.targetObject != null||IsPointerOverUI(gesture))
        {
            return;
        }
        if(GestureTransformationUtility.Raycast(gesture.startPosition,_hits,TrackableType.PlaneEstimated))
        {
            GameObject placedobj = Instantiate(DataHandler.Instance.GetFurniture(),pose.position,pose.rotation);


            var anchorObject =new GameObject("PlacementAnchor");
            anchorObject.transform.position = pose.position;
            anchorObject.transform.rotation = pose.rotation;
            placedobj.transform.parent =anchorObject.transform;

        }
    }  */ 
    

    

    // Update is called once per frame
    
    void Update()

      

    {        


        CrosshairCalculation();
        touch = Input.GetTouch(0);

        if (Input.touchCount<0 || touch.phase != TouchPhase.Began)
        return;

        if (IsPointerOverUI(touch))
         return;
         
    
        //if (Input.GetMouseButtonDown(0))
            
                Ray ray = arCam.ScreenPointToRay(touch.position);
            
    
               if (_raycastManager.Raycast(ray, _hits))
                
                {  Pose pose = _hits[0].pose;
                    Instantiate(DataHandler.Instance.furniture, pose.position, pose.rotation); 
                
                }
    }

         bool IsPointerOverUI(Touch touch)
        {
            PointerEventData eventData = new PointerEventData(EventSystem.current);
            eventData.position=new Vector2(touch.position.x,touch.position.y);
            List<RaycastResult> results=new List<RaycastResult>();
            EventSystem.current.RaycastAll(eventData,results);
            return results.Count>0;

        }




        void  CrosshairCalculation()
        {
            Vector3 origin= arCam.ViewportToScreenPoint(new Vector3(0.5f,0.5f,0));
            //if (Input.GetMouseButtonDown(0))
            Ray ray = arCam.ScreenPointToRay(origin);
             if (_raycastManager.Raycast(ray, _hits))
                {
                     pose = _hits[0].pose;
                     crosshair.transform.position = pose.position;
                     crosshair.transform.eulerAngles=new Vector3(90,0,0);
                    
                
                }


               /* //if (GestureTransformationUtility.Raycast(origin, _hits, TrackableType.PlaneEstimated))
                {
                     pose = _hits[0].pose;
                     crosshair.transform.position = pose.position;
                     crosshair.transform.eulerAngles=new Vector3(90,0,0);
                    

                }*/
        }
}
}
         

            

        
        
        

    
    

    




    




