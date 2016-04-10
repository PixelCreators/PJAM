using UnityEngine;
using System.Collections;
using GamepadInput;

public class SupeshotController : MonoBehaviour
{

    private bool _superhotMode;
	// Use this for initialization
	public void EnterSuperhotMode ()
	{
	    Time.timeScale = 0.001f;
	    _superhotMode = true;
	}

    void Update()
    {
        if(!_superhotMode)
            return;


        if (GamePad.GetAxis(GamePad.Axis.LeftStick, GamePad.Index.Any).x > 0 ||
             GamePad.GetAxis(GamePad.Axis.LeftStick, GamePad.Index.Any).y > 0 ||
             GamePad.GetAxis(GamePad.Axis.RightStick, GamePad.Index.Any).x > 0 ||
             GamePad.GetAxis(GamePad.Axis.RightStick, GamePad.Index.Any).y > 0)
        {
            Time.timeScale = 1.0f;

        }
        else
        {
            Time.timeScale = 0.001f;
        }
    }

    public void ExitSuperhotMode()
    {
        Time.timeScale = 1.0f;
        _superhotMode = true;
    }
}
