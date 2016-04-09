using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CutSceneController : MonoBehaviour
{
    public string NextLevelName;
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

    public void LoadNewLevel()
    {
        SceneManager.LoadScene(NextLevelName);
    }

    public void ResetLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
