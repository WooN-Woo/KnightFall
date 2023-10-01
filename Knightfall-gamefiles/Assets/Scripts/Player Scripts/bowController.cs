using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bowController : MonoBehaviour
{
    public GameObject arrow;

    public float arrowMultp;

    private void Update()
    {
        arrowController();
    }


    private void arrowController()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            arrowMultp += 50f;
        }

        if (Input.GetButtonUp("Fire2"))
        {
            Rigidbody rb = Instantiate(arrow, gameObject.transform.position, Quaternion.identity).GetComponent<Rigidbody>();
            rb.AddForce(transform.right * Mathf.Clamp(arrowMultp,20f,1600f), ForceMode.Impulse);
            rb.AddForce(transform.up * 2f, ForceMode.Impulse);
            arrowMultp= 0f;
        }
    }


}
