using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] StatsManager statsManager;
    AudioSource audioSource;

    private void Start() {
        audioSource = GameObject.FindGameObjectWithTag("GameController").GetComponent<AudioSource>();
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Finish"))
        {
            audioSource.PlayOneShot(audioSource.clip);
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            int nextSceneIndex = currentSceneIndex + 1;
            if (nextSceneIndex == SceneManager.sceneCountInBuildSettings - 1)
            {
                statsManager.IncreaseDifficulty();
                nextSceneIndex = 2;
            }
            SceneManager.LoadScene(nextSceneIndex);
        }
    }
}
