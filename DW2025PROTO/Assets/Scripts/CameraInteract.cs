using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraInteract : MonoBehaviour
{
    Camera cam;
    int clueNum = 0;

    ClueManager clueManager;
    Clue currentClue;

    void Start()
    {
        cam = Camera.main;
        clueManager = GetComponent<ClueManager>();
    }
    void Update()
    {
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        RaycastHit hit;

        Debug.DrawLine(cam.transform.position, cam.transform.position + cam.transform.forward * 7f);
        if (Physics.Raycast(ray, out hit, 7f))
        {
            if (hit.collider.gameObject.tag == "Interactable" && hit.collider.gameObject.GetComponent<Clue>().collected == false)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    hit.transform.gameObject.SendMessage("Interact", SendMessageOptions.DontRequireReceiver);

                    clueNum++;

                    if(TutorialController.instance.tutorialActive)
                    {

                        if (clueNum == 1)
                        {
                            TutorialController.instance.tutorialFirstClue();
                        }

                        else if (clueNum == clueManager.allClues.Count)
                        {
                            TutorialController.instance.tutorialLastClue();
                        }
                    }  
                }
            }
        }
    }
}
