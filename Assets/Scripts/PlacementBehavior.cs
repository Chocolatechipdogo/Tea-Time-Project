using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacementBehavior : MonoBehaviour
{

    public Transform pos;
    private Vector2 posToShare;
    public KettleBehavior TheKettle;
    private Vector2 lastPos;
    // Start is called before the first frame update
    void Start()
    {
        posToShare = new Vector2(pos.transform.position.x, pos.transform.position.y);
        lastPos = TheKettle.currentPos;
        Debug.Log("seeing position stored to be shared: " + posToShare.x + posToShare.y);
    }

    public void OnMouseEnter()
    {
        TheKettle.currentPos = posToShare;
    }
    public void OnMouseExit()
    {
        if (!TheKettle.canBeTrashed())
        {
            TheKettle.ResetPos();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
