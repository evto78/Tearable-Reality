using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MouseDrag : MonoBehaviour
{
    Button butt;
    public bool followMouse;
    public bool inPosition;
    public bool inCorrectPosition;

    Vector3 original;

    public GameObject slotObj;
    public GameObject[] anchorPoints;
    GameObject currentSlot;
    SlotOccupation sOcc;

    public float anchorDistance;

    public int timelinePointIndex;

    // Start is called before the first frame update
    void Start()
    {
        butt = gameObject.GetComponent<Button>();

        original = gameObject.transform.position;

        //slots = slotObj.GetComponent<TLSlots>();
        anchorPoints = slotObj.GetComponent<TLSlots>().slots;
    }

    // Update is called once per frame
    void Update()
    {

        if (followMouse)
        {
            butt.transform.position = Input.mousePosition;
        }

        if (EventSystem.current.IsPointerOverGameObject() && EventSystem.current.currentSelectedGameObject != null && EventSystem.current.currentSelectedGameObject.name == gameObject.name && Input.GetMouseButton(0))
        {
            followMouse = true;
            inPosition = false;
            inCorrectPosition = false;

            if(currentSlot != null)
            {
                sOcc = currentSlot.GetComponent<SlotOccupation>();
                sOcc.occupied = false;
            }
        }

        else if(Input.GetMouseButtonUp(0))
        {
            followMouse = false;
            anchorCheck();

            if (!inPosition)
            {
                gameObject.transform.position = original;
            }      
        }
    }

    void anchorCheck()
    {
        for(int i = 0; i < anchorPoints.Length; i++)
        {
            if(Vector3.Distance(gameObject.transform.position, anchorPoints[i].transform.position) <= anchorDistance)
            {
                sOcc = anchorPoints[i].gameObject.GetComponent<SlotOccupation>();

                if (sOcc.occupied == false)
                {
                    gameObject.transform.position = anchorPoints[i].transform.position;
                    currentSlot = anchorPoints[i].gameObject;
                    inPosition = true;
                    sOcc.occupied = true;

                    if (i == timelinePointIndex - 1)
                    {
                        inCorrectPosition = true;
                    }
                }
                break;    
            }


        }
    }
}
