using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField]
    float forceY = 10f;
    Rigidbody rb;
    public bool canJump = true;//Default to true
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && canJump)
        {
            Vector3 velocity = rb.velocity;
            velocity.y = forceY;
            rb.velocity = velocity;
        }
    }
}
