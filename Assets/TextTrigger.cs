using UnityEngine;
using System.Collections;

public class TextTrigger : MonoBehaviour
{
    public TextAutomateCompletion TextAutomateCompletion;
    private bool _triggered;

    void OnTriggerEnter(Collider other)
    { 
        if(_triggered)
            return;

        if (other.tag == "Player")
        {
            TextAutomateCompletion.TriggerNextText();
            _triggered = true;
        }
    }
}
