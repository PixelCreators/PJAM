using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;
using UnityStandardAssets.ImageEffects;

public class Level3Trigger : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            var player = other.GetComponent<FirstPersonController>();
            player.m_GravityMultiplier = 0.5f;
            player.m_JumpSpeed = 4.0f;
            player.m_StickToGroundForce = 1.0f;
            player.GetComponent<SupeshotController>().EnterSuperhotMode();
            player.GetComponent<CharacterController>().radius = 0.55f;
            var blooms = player.gameObject.GetComponentsInChildren<BloomOptimized>();
            foreach (var bloomOptimized in blooms)
            {
                bloomOptimized.enabled = false;
            }

        }
    }
}
