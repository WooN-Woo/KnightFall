using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene2loader : MonoBehaviour
{
    private void Update()
    {
        sceneLoader();
    }

    private void sceneLoader()
    {
        GameObject[] enemy = GameObject.FindGameObjectsWithTag("enemy");

        if (enemy.Length == 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}
