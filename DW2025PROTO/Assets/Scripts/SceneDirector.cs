using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneDirector : MonoBehaviour
{

    string[] terrors = {"test", "test2"};

    public int terrorSelectedNum;
    public int selected;

    string terrorSelected;

    // Start is called before the first frame update
    void Start()
    {
        terrorSelected = terrors[terrorSelectedNum];
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
        if(selected == terrorSelectedNum)
        {
            Debug.Log("CORRECT");
        }

        if(selected != terrorSelectedNum)
        {
            Debug.Log("INCORRECT");
            GameObject.Find("Detector").GetComponent<DetectorScript>().IncorrectGuess();
        }
    }
}
