using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class destroyArrow : MonoBehaviour
{
    float destroyCounter = 2f;
    AýScripts AýScripts;

    private void Awake()
    {
        AýScripts = FindObjectOfType<AýScripts>();
    }

    private void Update()
    {
        destroyCounter-= Time.deltaTime;

        if (destroyCounter <= 0) Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ground"))
        {
            Destroy(gameObject);
        }

        if (other.CompareTag("enemy"))
        {
            Destroy(gameObject);
            AýScripts.DestoryEnemy();
        }
    }

}
