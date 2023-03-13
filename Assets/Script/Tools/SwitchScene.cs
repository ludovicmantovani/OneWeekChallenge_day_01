using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    [SerializeField] private string sceneName = "";

    public void SwitchToScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
