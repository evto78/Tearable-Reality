using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clue : MonoBehaviour
{
    DialougeBoxPopUp diaBox;
    public bool collected;
    public string name;
    public int id;
    public string shownDescription;
    private void Start()
    {
        diaBox = GameObject.Find("dialouge box").GetComponentInChildren<DialougeBoxPopUp>();
    }
    public void Interact()
    {
        if (!collected) { collected = true; }
        diaBox.PopOut(shownDescription);
    }
}
