using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private void Start()
    {
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(-0.1f, 0.0f, 0.0f);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(0.1f, 0.0f, 0.0f);
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
