using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PlayGame() { SceneManager.LoadScene(2); }
    public void ExitGame() { Application.Quit(); }
    public void BackToMenu() { SceneManager.LoadScene(0); }
    public void HowToPlay() { SceneManager.LoadScene(1); } 
}
