using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKey(KeyCode.Escape)) { SceneManager.LoadScene(SceneManager.sceneCountInBuildSettings - 1); }
    }
}
