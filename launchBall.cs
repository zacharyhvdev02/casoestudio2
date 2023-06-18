using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class launchBall : MonoBehaviour
{
    public float speed;

    public Rigidbody2D rb;

    public float jumpAmount;

    private float direction = 1;

    private bool isGrounded = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        direction = Input.GetAxis("Horizontal");

        Debug.Log(direction);

        transform.Translate(direction * speed, 0, 0);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }

        else
        {
            isGrounded = false;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }

        else
        {
            isGrounded = false;
        }
    }
}
