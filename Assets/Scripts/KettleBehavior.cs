using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KettleBehavior : MonoBehaviour
{
    public GameObject TeaKettle;
    private bool holdingKettle;
    private bool notOG;
    const float OgX = -5.98f;
    const float OgY = 2.25f;
    private Vector2 kettleOGPostion = new Vector2(OgX, OgY);
    // Start is called before the first frame update
    void Start()
    {
        kettleOGPostion = new Vector2(TeaKettle.transform.position.x, TeaKettle.transform.position.y);
    }


    public void OnMouseDown()
    {
        holdingKettle = true;
        notOG = true;
    }

    public void OnMouseUp()
    {
        holdingKettle = false; 
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("see OG X: " + OgX);
        if (holdingKettle)
        {
            Debug.Log("see x position: " + TeaKettle.transform.position.x);
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
            
        }
        else if (notOG) // Currently the object can't be let go without it going wild 
        {
            
            transform.Translate(kettleOGPostion);
            notOG = false;
        }
        

    }
}
