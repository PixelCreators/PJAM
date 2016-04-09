using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class RopeEnter : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            var player = other.GetComponent<ShakePlayer>();
            player.GetComponent<CharacterController>().radius = 0.1f;
            player.isPlayerShaking = true;
        }
    }
}
