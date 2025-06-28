using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TablePlacementBehavior : PlacementBehavior
{

    private int orderNumber = 1;
    


    // Start is called before the first frame update
    void Start()
    {
        posToShare = new Vector2(pos.transform.position.x, pos.transform.position.y);
    }

    public void OnMouseEnter()
    {
        if(TheKettle.GetCurrentOrder() < orderNumber)
        {

            //TheKettle.currentPos = posToShare;
            //TheKettle.prevPos = posToShare;
            TheKettle.SetCurrentOrder(orderNumber);
            Debug.Log("Entered TABLE area!");
            Debug.Log("The Kettle's order: " + TheKettle.GetCurrentOrder());
        }
    }

    /*public void OnMouseExit()
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
