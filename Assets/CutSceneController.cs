using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CutSceneController : MonoBehaviour
{

    private Animator _animator;

	// Use this for initialization
	void Awake ()
	{
	    _animator = GetComponent<Animator>();
	}

    public void PlayLoadLevelAnim()
    {
        _animator.Play("NewLevel");
    }

    void Update()
    {
    }

    public void LoadNewLevel(string NextLevelName)
    {
        SceneManager.LoadScene(NextLevelName);
    }


}
