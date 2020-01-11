using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(IsGrounded))]
public class Jump : MonoBehaviour
{
    Rigidbody rb;
    IsGrounded ig;
    [SerializeField] float force = 5f;
    bool jump;//Jumps when true.
    void Start()
    {
        rb = GetComponentInParent<Rigidbody>();
        ig = GetComponent<IsGrounded>();
    }
    private void Update() => jump = rb && ig.grounded && Input.GetButtonDown("Jump");
    private void FixedUpdate()
    {
        if (rb && jump)
        {
            var vel = rb.velocity;
            vel.y += force;
            rb.velocity = vel;
        }
    }
}
