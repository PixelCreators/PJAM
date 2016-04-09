using System;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    public string NextLevelName;

   

    void OnTriggerEnter(Collider other)
    {
        other.GetComponentInChildren<MainCamera>().gameObject.SetActive(false);
        var cutscene = other.GetComponentInChildren<CutSceneController>();
        cutscene.NextLevelName = NextLevelName;
        cutscene.PlayLoadLevelAnim();
        
    }   
}
