using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventMaster : MonoBehaviour
{

    public GameObject[] events;
    int correctScore;

    public bool correctTimeline;

    MouseDrag mouseDrag;

    SceneChange sceneC;

    // Start is called before the first frame update
    void Start()
    {
        correctTimeline = false;
        sceneC = GetComponent<SceneChange>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void checkTimeline()
    {
        correctTimeline = false;
        correctScore = 0;

        for (int i = 0; i < events.Length; i++)
        {
            mouseDrag = events[i].gameObject.GetComponent<MouseDrag>();

            if (mouseDrag.inCorrectPosition)
            {
                correctScore++;
            }
        }

        if(correctScore == events.Length)
        {
            correctTimeline = true;
            sceneC.changeScene();
        }
        else
        {
            GameObject.Find("Detector").GetComponent<DetectorScript>().IncorrectGuess();
        }

        Debug.Log(correctTimeline);
    }
}
