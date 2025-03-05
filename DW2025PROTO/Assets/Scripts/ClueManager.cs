using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClueManager : MonoBehaviour
{
    public List<Clue> allClues;
    void Start()
    {
        foreach (Clue clue in allClues)
        {
            clue.collected = false;
        }
    }
    void Update()
    {
        foreach (Clue clue in allClues)
        {
            //Debug.Log("Clue: " + clue.name + ". Is it collected? " + clue.collected);
        }
    }
}
