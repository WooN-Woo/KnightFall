using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword : MonoBehaviour
{
    //AýScripts AýScripts;

    //private void Awake()
    //{
    //    AýScripts = FindObjectOfType<AýScripts>();
    //}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("enemy"))
        {
            Destroy(other.gameObject);
            
        }
    }
}
