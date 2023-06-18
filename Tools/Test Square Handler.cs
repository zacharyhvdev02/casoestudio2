using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSquareHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(1,1));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
