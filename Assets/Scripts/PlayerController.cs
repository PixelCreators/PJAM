using UnityEngine;
using GamepadInput;

public class PlayerController : MonoBehaviour
{
    private Rigidbody _rigidbody;

    public GamePad.Index PlayerIndex;
    public float Force; 

	public void Awake ()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
	
	public void Update ()
	{
	    var axisRightStick = GamePad.GetAxis(GamePad.Axis.RightStick, PlayerIndex);
        

        _rigidbody.AddForce(new Vector3(axisRightStick.x * Force, 0.0f, axisRightStick.y * Force));
        _rigidbody.MoveRotation(Quaternion.LookRotation(new Vector3(axisRightStick.x, 0.0f, axisRightStick.y)));
	}

    public void FixedUpdate()
    {
        
    }
}
