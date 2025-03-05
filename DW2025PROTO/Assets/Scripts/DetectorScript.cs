using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectorScript : MonoBehaviour
{
    public Image graph;
    public List<Sprite> graphLvl0;
    public List<Sprite> graphLvl1;
    public List<Sprite> graphLvl2;
    public List<Sprite> graphLvl3;
    public List<Sprite> graphLvl4;
    Image image;
    public Sprite on;
    public Sprite off;
    public float bobIntensity;
    public int guessesRemaining;
    public int guessesMax;
    public float beepFreqMin;
    public float beepFreqMax;
    float curBeepFreq;
    float beepFreqTimer;
    void Start()
    {
        image = gameObject.GetComponent<Image>();
        image.sprite = off;
        guessesRemaining = guessesMax;
        beepFreqTimer = beepFreqMin;
        curBeepFreq = beepFreqMin;
    }

    // Update is called once per frame
    void Update()
    {
        beepFreqTimer -= Time.deltaTime;

        if(beepFreqTimer <= 0) { image.sprite = on; beepFreqTimer = curBeepFreq; }
        if(beepFreqTimer <= ((curBeepFreq * 3) / 4)) { image.sprite = off; }
    }
}
