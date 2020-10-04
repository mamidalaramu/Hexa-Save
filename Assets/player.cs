using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    public float moveSpeed = 600f;
    float movement = 0f;
    // Update is called once per frame

    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");

        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).position.x - Screen.width / 2 > 0)
            {
                movement = 1.0f;
            }
            else
            {
                movement = -1.0f;
            }
        }
    }
    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
