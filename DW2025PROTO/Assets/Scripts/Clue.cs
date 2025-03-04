using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clue : MonoBehaviour
{
    public bool collected;
    public string name;
    public int id;

    public void Interact()
    {
        if (!collected) { collected = true; }
    }
}
