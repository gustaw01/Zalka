using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Summary : MonoBehaviour
{
    [SerializeField] TMP_Text difficutyText;
    [SerializeField] StatsManager statsManager;
    GameManager gameManager;

    private void Awake() {
        gameManager = GameManager.instance;
        difficutyText.text = "You have reached " + gameManager.difficulty + " difficulty level.";
        gameManager.lifes = 3;
        gameManager.difficulty = 0;
    }

}