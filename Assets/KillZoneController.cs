using UnityEngine;
using System.Collections;

public class KillZoneController : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<AnimationController>().PlayDie();
        }
    }
}
