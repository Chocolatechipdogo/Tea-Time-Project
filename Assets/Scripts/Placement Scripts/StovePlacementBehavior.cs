using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StovePlacementBehavior : PlacementBehavior
{

    private int orderNumber = 2;




    // Start is called before the first frame update
    void Start()
    {
        posToShare = new Vector2(pos.transform.position.x, pos.transform.position.y);
    }


    public void OnMouseEnter()
    {
        if (TheKettle.GetCurrentOrder() < orderNumber)
        {

            TheKettle.currentPos = posToShare;
            TheKettle.SetCurrentOrder(orderNumber);
            Debug.Log("Entered STOVE area");

        }
    }

  /*  public void OnMouseExit()
    {
        if (!TheKettle.canBeTrashed())
        {
            TheKettle.currentPos = TheKettle.prevPos;

            TheKettle.SetCurrentOrder(TheKettle.GetCurrentOrder() - 1);
        }
    }
  */

    // Update is called once per frame
    void Update()
    {
        
    }
}
