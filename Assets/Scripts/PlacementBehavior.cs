using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacementBehavior : MonoBehaviour
{

    public Transform pos;
    private Vector2 posToShare;
    public KettleBehavior TheKettle;
    private Vector2 ogPos;
    // Start is called before the first frame update
    void Start()
    {
        posToShare = new Vector2(pos.transform.position.x, pos.transform.position.y);
        ogPos = TheKettle.kettleOGPostion;
        Debug.Log("seeing position stored to be shared: " + posToShare.x + posToShare.y);
    }

    public void OnMouseEnter()
    {
        TheKettle.kettleOGPostion = posToShare;
    }
    public void nMouseExit()
    {
        TheKettle.kettleOGPostion = ogPos;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
