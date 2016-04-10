using UnityEngine;
using System.Collections;

public class AnimationController : MonoBehaviour
{
    public CutSceneController _cutSceneController;
    private Animator cutsceneAnimator;

    public void Awake()
    {
        cutsceneAnimator = GetComponentInChildren<Animator>();
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
    
}
