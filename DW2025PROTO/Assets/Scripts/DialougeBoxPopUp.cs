using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialougeBoxPopUp : MonoBehaviour
{
    public TextMeshProUGUI descText;
    RectTransform myRect;
    public Vector3 inPos;
    public Vector3 outPos;
    float popOutTimer;
    bool poppingOut;
    float popInTimer;
    bool poppingIn;
    float popStayTimer;
    bool staying;
    void Start()
    {
        myRect = gameObject.GetComponent<RectTransform>();
        poppingOut = false;
        poppingIn = false;
        staying = false;
    }
    void Update()
    {
        popOutTimer -= Time.deltaTime * 2f;
        popInTimer -= Time.deltaTime * 2f;
        popStayTimer -= Time.deltaTime;
        if (poppingOut)
        {
            myRect.position = new Vector3(Mathf.Lerp(outPos.x, inPos.x, popOutTimer) + 1950, myRect.position.y, 0);
            if (popOutTimer <= 0) { poppingOut = false; popStayTimer = 4f; staying = true; }
        }
        else if (staying)
        {
            if (popStayTimer <= 0) { staying = false; popInTimer = 1f; poppingIn = true; }
        }
        else if (poppingIn)
        {
            myRect.position = new Vector3(Mathf.Lerp(inPos.x, outPos.x, popInTimer) + 1950, myRect.position.y, 0);
            if (popInTimer <= 0) { poppingIn = false; }
        }
    }
    public void PopOut(string txt)
    {
        myRect.position = inPos;
        poppingIn = false;
        staying = false;
        popOutTimer = 1f;
        poppingOut = true;
        descText.text = txt;
    }
}
