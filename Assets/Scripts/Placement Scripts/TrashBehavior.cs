using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashBehavior : PlacementBehavior
{


    //private int orderNumber = -1;




    // Start is called before the first frame update
    void Start()
    {
        posToShare = new Vector2(pos.transform.position.x, pos.transform.position.y);
    }


    public void OnMouseEnter()
    {
        if (TheKettle.GetCurrentOrder() != 0)
        { 
            TheKettle.ResetPos();
            Debug.Log("Entered Trash area");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
