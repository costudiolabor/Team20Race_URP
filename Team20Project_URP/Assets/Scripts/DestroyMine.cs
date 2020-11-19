using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMine : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" || other.tag == "Player2")
        {
            Debug.Log(other.tag);
            Destroy(gameObject);
        }
    }
}
