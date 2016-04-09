using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class SwitchToPlayer : MonoBehaviour
{
    public Vector3 SpawnPoint;
    public Vector3 Rotation;
    public GameObject Player;

    public void Switch()
    {
        Instantiate(Player, SpawnPoint, Quaternion.Euler(Rotation));
    }
}
