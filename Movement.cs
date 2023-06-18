using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody playerRb;

    CharacterController playerController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Working updates");
    }

    private void FixedUpdate()
    {
        if (playerRb != null)
        {
            // move player left to right

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playerController.Move(new Vector2(1, 0));
            }
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log("Collided with something");

        if (coll.gameObject.CompareTag("Ground"))
        {
            Debug.Log("welp touched the ground");
        }
    }
}
