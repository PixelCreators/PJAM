using UnityEngine;
using System.Collections;

public class AnimationController : MonoBehaviour
{
    public CutSceneController _cutSceneController;
    private Animator cutsceneAnimator;
    private Animator mainCameraAnimator;

    public void Awake()
    {
        cutsceneAnimator = GetComponentInChildren<Animator>();
        mainCameraAnimator = GetComponent<Animator>();
    }

    public void Switch()
    {
        FindObjectOfType<SwitchToPlayer>().Switch();
        gameObject.SetActive(false);
    }

    public void PlayDie()
    {
        cutsceneAnimator = GetComponentInChildren<Animator>();
        if (cutsceneAnimator != null)
            cutsceneAnimator.Play("Die");
    }

    public void PlayStart()
    {
        if(mainCameraAnimator != null)
            mainCameraAnimator.Play("WakeUp");
    }
    
}
