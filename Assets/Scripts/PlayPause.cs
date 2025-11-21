using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayPause : MonoBehaviour

{
    public Timer timerscript;
    public bool timerOn;

    void Start()
    {
        timerOn = true;
    }

    public void OnClick()
    {
    if(timerOn == true)
        {
            timerscript.StopTimer();
            timerOn = false;
            Debug.Log("pause");
        }
    else
        {
            timerscript.StartTimer();
            timerOn = true;
            Debug.Log("play");
        }
    }
}
