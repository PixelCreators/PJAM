using UnityEngine;
using System.Collections;

public class KillZoneController : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            var anim = other.GetComponent<AnimationController>();
            anim._cutSceneController.gameObject.SetActive(true);
            anim.PlayDie();
        }
    }
}
