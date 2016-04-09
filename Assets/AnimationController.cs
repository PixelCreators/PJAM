using UnityEngine;
using System.Collections;

public class AnimationController : MonoBehaviour {

    public void Switch()
    {
        FindObjectOfType<SwitchToPlayer>().Switch();
        gameObject.SetActive(false);
    }
}
