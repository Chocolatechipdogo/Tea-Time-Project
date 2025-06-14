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
    private bool EnteredPlacement;



    // Start is called before the first frame update
    void Start()
    {
        kettleOGPostion = new Vector2(TeaKettle.transform.position.x, TeaKettle.transform.position.y);
        currentPos = kettleOGPostion;
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
        else if (!holdingKettle && notOG) // Currently the object only goes back to the start 
        {
            
            transform.position = currentPos;
            notOG = false;
            
        }
       
        
        

    }

    public void ResetPos()
    {
        currentPos = kettleOGPostion;
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
