using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpeechController : MonoBehaviour
{

    public GameObject speechObj;
    TextMeshProUGUI speechText;

    public static SpeechController instance;

    // Start is called before the first frame update
    void Start()
    {
        //speechText = speechText.GetComponentInChildren<TextMeshProUGUI>();

        instance = this;

        displayText("AOAOAOA", 5, false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void displayText(string text, float uptime, bool dontUseUptime)
    {
        speechObj.SetActive(true);

        speechText = speechObj.GetComponentInChildren<TextMeshProUGUI>();
        speechText.text = text;

        if (!dontUseUptime)
        {
            StartCoroutine(hideTextAfterTime(uptime));
        }

    }

    public IEnumerator hideTextAfterTime(float length)
    {
        yield return new WaitForSeconds(length);

        speechObj.SetActive(false);
    }
}
