using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public float sensitvity = 200f;

    public Transform playerBody;

    public float xRotation = 0f;

    public monsterChecker monsterCheck;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    
    void Update()
    {
       if (monsterCheck.menu == false)
        {
            float mouseX = Input.GetAxis("Mouse X") * sensitvity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * sensitvity * Time.deltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);

            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            playerBody.Rotate(Vector3.up * mouseX);
        }

        mouseLock();
    }

    void mouseLock()
    {
        if (monsterCheck.menu == true)
        {
            Cursor.lockState = CursorLockMode.None;
        }

        if (monsterCheck.menu == false)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
