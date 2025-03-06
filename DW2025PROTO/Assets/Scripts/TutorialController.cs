using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialController : MonoBehaviour
{

    public bool tutorialActive;

    public static TutorialController instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void tutorialFirstClue()
    {
        SpeechController.instance.displayText("Wonderful. Feel free to take notes of your finding or reinspect it however, don’t you dare write anything on those Tearror documents! Ahem. Keep collecting clues until you feel confident enough to begin your deductions.", 10, false);
    }

    public void tutorialLastClue()
    {
        SpeechController.instance.displayText("Feeling confident? Go over everything you found if you aren’t. Otherwise, get your clipboard  and mark down which Tearror you believe is responsible for this crime scene.", 10, false);
    }

    public void tutorialGuessWrong()
    {
        SpeechController.instance.displayText("I should mention that being wrong takes time and if you take enough time who knows what might show up… ", 10, false);
    }

    public void tutorialGuessWrong2()
    {
        SpeechController.instance.displayText("You’re lucky the Tearror who killed the victim had already been captured and this is a mock case, if this was a real one I would be terribly disappointed and you’d already be “fired”.", 10, false);
    }

    public void tutorialGuessWrong3()
    {
        SpeechController.instance.displayText("Normally you’d be dead at this point.", 5, false);
    }

    public void tutorialGuessRightFirstTry()
    {
        SpeechController.instance.displayText("Wonderful work. Guessing wrong would have taken time and if you had guessed incorrectly too many times well, who knows what might have shown up.", 8, false);
    }

    public void tutorialGuessRight()
    {
        SpeechController.instance.displayText("Now we know what we’re after, we still have to figure out exactly how things happened, we don’t want to send the team after an extremely irritated monster after all. Pull up your clipboard and put things together on the timeline. Remember incorrect deductions take time.", 10, false);
    }
}
