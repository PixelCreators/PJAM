using UnityEngine;
using System.Collections;

public class RopeExit : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            var player = other.GetComponent<ShakePlayer>();
            player.GetComponent<CharacterController>().radius = 0.5f;
            player.isPlayerShaking = false;
        }
    }
}
