using UnityEngine;
using System.Collections;
using GamepadInput;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TextAutomateCompletion : MonoBehaviour
{
    public Text textBox;
    public bool isBegginingText;
    private bool _waitNow;
    public bool StartigScene;
    private bool justOnce = false;

    //Store all your text in this string array
    public string[] goatText = new string[] { "One night with Alice...", "Not a VR Experience", "Alice is a little girl. She'd just turned 7.", "She had a lot of cake and soda before sleep.", "She also went to bed very late. Alice is very, very naughty!", "Let's hope she'll have nightmares!", "CHAPTER I: \"Is it my bedroom?\"" };
    int currentlyDisplayingText = 0;
    void Awake()
    {
        StartCoroutine(AnimateText());
    }
    //This is a function for a button you press to skip to the next text
    public void SkipToNextText()
    {
        StopAllCoroutines();
        currentlyDisplayingText++;
        //If we've reached the end of the array, do anything you want. I just restart the example text
        if (currentlyDisplayingText > goatText.Length)
        {
            currentlyDisplayingText = 0;
        }
        StartCoroutine(AnimateText());
    }
    //Note that the speed you want the typewriter effect to be going at is the yield waitforseconds (in my case it's 1 letter for every      0.03 seconds, replace this with a public float if you want to experiment with speed in from the editor)
    IEnumerator AnimateText()
    {

        for (int i = 0; i < (goatText[currentlyDisplayingText].Length + 1); i++)
        {
            textBox.text = goatText[currentlyDisplayingText].Substring(0, i);
            yield return new WaitForSeconds(.04f);
        }
        yield return new WaitForSeconds(0.8f);

        if(!_waitNow)
            NextLineOfText();
    }

    void Update()
    {
        if (GamePad.GetButtonDown(GamePad.Button.A, GamePad.Index.One))
        {
            if(currentlyDisplayingText + 1 >= goatText.Length && StartigScene)
                SceneManager.LoadScene("Level");
            //else
                //SkipToNextText();
        }
    }

    public void NextLineOfText()
    {
        
        if (goatText[currentlyDisplayingText] == " ")
        {
            if (isBegginingText)
            {
                if (!justOnce)
                {
                    transform.parent.parent.GetComponentInChildren<AnimationController>().PlayStart();
                    justOnce = true;
                }
            }
            _waitNow = true;
            return;
        }

        if (currentlyDisplayingText + 1 >= goatText.Length)
            return;

        SkipToNextText();
    }

    public void TriggerNextText()
    {
        SkipToNextText();
        _waitNow = false;
    }
}
