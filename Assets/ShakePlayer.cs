using UnityEngine;
using System.Collections;

public class ShakePlayer : MonoBehaviour
{

    private float _currentDeviaton;
    public float DeviationStep = 0.05f;
    public float MaxDeviation;
    public float MinDeviation;
    public bool ToMaxDeviation;

    public bool isPlayerShaking;

    void Start ()
	{
	    _currentDeviaton = 0;

	}
	


	void FixedUpdate ()
	{
        if(!isPlayerShaking)
            return;

	    if (_currentDeviaton <= MaxDeviation && ToMaxDeviation)
	    {
	        _currentDeviaton += DeviationStep;
	        transform.position = transform.right*DeviationStep*Time.deltaTime + transform.position;
	    }
	    else
	        ToMaxDeviation = false;

	    if (_currentDeviaton >= MinDeviation && !ToMaxDeviation)
	    {
	        _currentDeviaton -= DeviationStep;
            transform.position = transform.position - transform.right * DeviationStep * Time.deltaTime;
        }
	    else
	        ToMaxDeviation = true;

        
	}
}
