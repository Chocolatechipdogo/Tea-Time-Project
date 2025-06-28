using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class KettleBehavior : MonoBehaviour
{
    public GameObject TeaKettle;
    public GameObject tablePlacement;
    private bool holdingKettle;
    private bool notOG = false;
    private Vector2 kettleOGPostion;
    public Vector2 currentPos;
    public Vector2 prevPos;
    private bool EnteredPlacement;
    private int currentOrder = 0;


    // Start is called before the first frame update
    void Start()
    {
        kettleOGPostion = new Vector2(TeaKettle.transform.position.x, TeaKettle.transform.position.y);
        currentPos = kettleOGPostion;
        prevPos = kettleOGPostion;
    }

    public int GetCurrentOrder() 
    {
        return currentOrder;
    }

    public void SetCurrentOrder(int newOrder) 
    {
        currentOrder = newOrder;
    }



    public void OnMouseDown()
    {
        holdingKettle = true;
        notOG = true;
    }

    public void OnMouseUp()
    {
        holdingKettle = false;
        transform.Translate(currentPos);
        if (currentPos != kettleOGPostion)
        {
            EnteredPlacement = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        if (holdingKettle)
        {
            
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
            
        }
        else if (!holdingKettle && notOG)
        {

        
            transform.position = currentPos;
            notOG = false;
            
        }
    
       
        
        

    }

    public void ResetPos()
    {
        currentPos = kettleOGPostion;
        currentOrder = 0;
    }

    

    public bool canBeTrashed()
    {
        if (EnteredPlacement)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
