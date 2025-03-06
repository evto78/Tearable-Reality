using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneDirector : MonoBehaviour
{

    string[] terrors = {"Galizard", "Icesythecle", "Clean Claw"};

    public int terrorSelectedNum;
    public int selected;

    string terrorSelected;

    public bool correctGuess;


    void Start()
    {
        terrorSelected = terrors[terrorSelectedNum];
    }

    void Update()
    {
        if(selected == terrorSelectedNum)
        {
            correctGuess = true;
        } 

        if (selected != terrorSelectedNum)
        {
            correctGuess = false;
        }
    }

    public void selector1()
    {
        selected = 0;
    }

    public void selector2()
    {
        selected = 1;
    }

    public void selector3()
    {

        selected = 2;

    }

    public void check()
    {
        if(correctGuess == true)
        {
            Debug.Log("CORRECT");
        }

        if(correctGuess == false)
        {
            Debug.Log("INCORRECT");
            GameObject.Find("Detector").GetComponent<DetectorScript>().IncorrectGuess();
        }
    }
}
