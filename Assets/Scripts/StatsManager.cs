using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class StatsManager : MonoBehaviour
{
    [SerializeField] TMP_Text lifeText;
    [SerializeField] TMP_Text difficultyText;

    GameManager gameManager;

    private void Awake() {
        gameManager = GameManager.instance;
        lifeText.text = "Lifes: " + gameManager.lifes.ToString();
        difficultyText.text = "Difficulty: " + gameManager.difficulty.ToString();
    }

    public void DecreaseLifesAmount()
    {
        gameManager.lifes -= 1;
        lifeText.text = "Lifes: " + gameManager.lifes.ToString();
    }

    public void IncreaseDifficulty()
    {
        gameManager.difficulty += 1;
        difficultyText.text = "Difficulty: " + gameManager.difficulty.ToString();
    }

    public int GetDifficulty() { return gameManager.difficulty; }

    private void Update() {
        if (gameManager.lifes <= 0)
        {
            SceneManager.LoadScene(SceneManager.sceneCountInBuildSettings - 1);
        }
    }
}
