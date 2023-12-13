using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    // Przykładowe zmienne liczbowe, które będą przechowywane
    public int lifes = 3;
    public float lifesCollected;
    public int difficulty = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
