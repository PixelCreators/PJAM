using UnityEngine;
using System.Collections;

public class AnimationController : MonoBehaviour
{

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
        if(cutsceneAnimator != null)
            cutsceneAnimator.Play("Die");
    }
    
}
