using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchPad : MonoBehaviour
{
    [SerializeField] StatsManager statsManager;
    [SerializeField] Transform startPatform;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerExit(Collider other) {

        if (other.gameObject.tag == "Player")
        {
            other.gameObject.transform.position = startPatform.position + Vector3.up * 2;;
        }
    }
}
