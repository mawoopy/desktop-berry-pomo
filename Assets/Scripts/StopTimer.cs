using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class StopTimer : MonoBehaviour
{
    public Timer timerScript;

    public PlayPause playpausescript;

public void OnClick()
{
    {
        timerScript.StopTimer();
        playpausescript.timerOn = false;
        Debug.Log("timer stopped");
    }
}
}
