using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealtScript : MonoBehaviour
{
    public int maxHealt;
    public int currentHealt;

    private void Start()
    {
        currentHealt = maxHealt;
    }

    private void Update()
    {
        if(currentHealt <= 0 )
        {
            SceneManager.LoadScene(0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("bullet"))
        {
            currentHealt -= 10;
        }
    }
}