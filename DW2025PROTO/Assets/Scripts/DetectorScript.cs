using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
    public float guessesRemaining;
    public float guessesMax;
    public float beepFreqMin;
    public float beepFreqMax;
    float curBeepFreq;
    float beepFreqTimer;
    float graphTimer;
    int graphSprite;
    void Start()
    {
        image = gameObject.GetComponent<Image>();
        image.sprite = off;
        guessesRemaining = guessesMax;
        beepFreqTimer = beepFreqMin;
        curBeepFreq = beepFreqMin;
        graphSprite = 0;
        graph.sprite = graphLvl0[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) { guessesRemaining -= 1; }

        beepFreqTimer -= Time.deltaTime;

        if(beepFreqTimer <= 0) { image.sprite = on; beepFreqTimer = curBeepFreq; }
        if(beepFreqTimer <= ((curBeepFreq * 3) / 4)) { image.sprite = off; }

        curBeepFreq = Mathf.Lerp(beepFreqMax, beepFreqMin, guessesRemaining / guessesMax);

        UpdateGraph();
    }
    public void IncorrectGuess()
    {
        if(guessesRemaining == guessesMax && TutorialController.instance.tutorialActive)
        {
            TutorialController.instance.tutorialGuessWrong();
        }

        guessesRemaining -= 1; if (guessesRemaining < 0) { guessesRemaining = 0; }

        if(guessesRemaining == 0 && TutorialController.instance.tutorialActive == false)
        {
            SceneManager.LoadScene("GameOverScreen");
        }
    }
    void UpdateGraph()
    {
        graphTimer -= Time.deltaTime;
        if (graphTimer <= 0)
        {
            graphSprite += 1;
            if(graphSprite >= 5) { graphSprite = 0; }
        }
        if (guessesRemaining / guessesMax == 1)
        {
            graph.sprite = graphLvl0[graphSprite];
        }
        else if (guessesRemaining / guessesMax >= 0.8)
        {
            graph.sprite = graphLvl1[graphSprite];
        }
        else if (guessesRemaining / guessesMax >= 0.6)
        {
            graph.sprite = graphLvl2[graphSprite];
        }
        else if (guessesRemaining / guessesMax >= 0.4)
        {
            graph.sprite = graphLvl3[graphSprite];
        }
        else if (guessesRemaining / guessesMax >= 0)
        {
            graph.sprite = graphLvl4[graphSprite];
        }
    }
}
