using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    Vector3 startingPosition;
    [SerializeField] Vector3 movementVector;
    float movementFactor;
    [SerializeField] float period = 20f;
    StatsManager statsManager;
    float move_factor;

    // Start is called before the first frame update
    void Start()
    {
        statsManager = GameObject.FindGameObjectWithTag("Column").GetComponent<StatsManager>();

        startingPosition = transform.position;

        move_factor = statsManager.GetDifficulty();
        if (move_factor >= period)
        {
            move_factor = period - 1;
        }
        period -= move_factor;
        Debug.Log(period);
    }

    // Update is called once per frame
    void Update()
    {
        if(period <= Mathf.Epsilon) { return; }
        float cycles = Time.time / period; // continually growing over time

        const float tau = Mathf.PI * 2; // constant value of 6.283
        float rawSinWave = Mathf.Sin(cycles * tau); // going from -1 to 1

        movementFactor = (rawSinWave + 1f) / 2f; // recalculated to go from 0 to 1

        Vector3 offset = movementVector * movementFactor;
        transform.position =  startingPosition + offset;
    }
}
