using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuitApplication : MonoBehaviour
{
    public void OnClick()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
