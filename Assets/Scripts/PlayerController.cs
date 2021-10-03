using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rigidBody;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        Debug.Log("x :");
        Debug.Log(x);
        Debug.Log("transform :");
        Debug.Log(transform.right);

        if (x > 0)
        {
            rigidBody.AddForce(transform.right * 8.0f);
        }
        else if (x < 0)
        {
            rigidBody.AddForce(-transform.right * 8.0f);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Meat"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
