using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacementBehavior : MonoBehaviour
{

    public Transform pos;
    [HideInInspector]
    public Vector2 posToShare;

    public KettleBehavior TheKettle;
    // Start is called before the first frame update
    void Start()
    {
        //posToShare = new Vector2(pos.transform.position.x, pos.transform.position.y);
        //Debug.Log("seeing position stored to be shared: " + posToShare.x + posToShare.y);
    }

    /* public Vector2 GetPosToShare()
     {
         return posToShare;
     }

      public void SetPosToShare() 
      {
          posToShare = new Vector2(pos.transform.position.x, pos.transform.position.y);

      }

     public Vector2 GetLastPos()
     {
         return lastPos;
     }
     public void SetLastPos()
     {
         lastPos = TheKettle.currentPos;

     }

     */

    /* public void OnMouseEnter()
     {
         TheKettle.currentPos = posToShare;
         Debug.Log("Entered area!");
     }

     public void OnMouseExit()
     {
         if (!TheKettle.canBeTrashed())
         {
             TheKettle.ResetPos();
         }
     }
    */
    // Update is called once per frame
    void Update()
    {
        
    }
}
