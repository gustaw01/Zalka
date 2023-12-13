using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] StatsManager statsManager;
    float difficulty_adjustment;
    [SerializeField] float startSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        difficulty_adjustment = startSpeed * statsManager.GetDifficulty();
        if (difficulty_adjustment == 0) { difficulty_adjustment = -0.1f; }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(
            0,
            difficulty_adjustment,
            0
            );
    }
}
