using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class monsterChecker : MonoBehaviour
{
    public bool menu;

    private Canvas canvas;
    public AudioSource openClipboard;
    public AudioSource closeClipboard;

    void Start()
    {
        openClipboard = GetComponent<AudioSource>();
        closeClipboard = GetComponent<AudioSource>();
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            canvas.enabled = true;
            menu = true;
            openClipboard.Play();
        }

    }

    public void closeMenu()
    {
        if (canvas.enabled == true)
        {
            canvas.enabled = false;
            menu = false;
            closeClipboard.Play();
        }
    }
}
