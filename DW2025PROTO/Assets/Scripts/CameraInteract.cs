using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraInteract : MonoBehaviour
{
    Camera cam;

    void Start()
    {
        cam = Camera.main;
    }
    void Update()
    {
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        RaycastHit hit;

        Debug.DrawLine(cam.transform.position, cam.transform.position + cam.transform.forward * 7f);
        if (Physics.Raycast(ray, out hit, 7f))
        {
            if (hit.collider.gameObject.tag == "Interactable")
            {
                if (Input.GetMouseButtonDown(0))
                {
                    hit.transform.gameObject.SendMessage("Interact", SendMessageOptions.DontRequireReceiver);
                }
            }
        }
    }
}
