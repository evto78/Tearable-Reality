using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCam : MonoBehaviour
{
    Transform camPos;
    void Update()
    {
        camPos = Camera.main.transform;
        transform.LookAt(camPos);
        transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y, 0);
    }
}
