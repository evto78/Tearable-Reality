using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneDirector : MonoBehaviour
{

    string[] terrors = {"Galizard", "Icesythecle", "Clean Claw", "Spot", "Moonchild", "Brazen Bull"};

    public int terrorSelectedNum;
    public int selected;

    string terrorSelected;

    public Button timelineButton;
    public bool correctGuess;
    public GameObject checklistHolder;
    public List<Toggle> checks = new List<Toggle>();

    void Start()
    {
        timelineButton = GameObject.Find("TimelineButton").GetComponent<Button>();
        timelineButton.interactable = false;
        checklistHolder = GameObject.Find("monsterChecker");
        for(int i = 0; i < checklistHolder.transform.childCount; i++)
        {
            if (checklistHolder.transform.GetChild(i).TryGetComponent<Toggle>(out Toggle givenToggle))
            {
                checks.Add(givenToggle);

            }
        }
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

    public void selector4()
    {

        selected = 3;

    }

    public void selector5()
    {

        selected = 4;

    }

    public void selector6()
    {

        selected = 5;

    }

    public void check()
    {
        if(correctGuess == true)
        {
            //Debug.Log("CORRECT");
            foreach(Toggle box in checks)
            {
                box.interactable = false;
            }

            timelineButton.interactable = true;

            if (TutorialController.instance.tutorialActive)
            {
                TutorialController.instance.tutorialGuessRight();
            }
            
        }

        if(correctGuess == false)
        {
            //Debug.Log("INCORRECT");
            GameObject.Find("Detector").GetComponent<DetectorScript>().IncorrectGuess();
        }
    }
}
