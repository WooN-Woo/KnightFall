using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword : MonoBehaviour
{
    //A�Scripts A�Scripts;

    //private void Awake()
    //{
    //    A�Scripts = FindObjectOfType<A�Scripts>();
    //}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("enemy"))
        {
            Destroy(other.gameObject);
            
        }
    }
}
