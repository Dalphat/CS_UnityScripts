using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class Move : MonoBehaviour
{
    Rigidbody rb;
    public float force = 1f;
    float input;
    [HideInInspector] public float direction;
    // Start is called before the first frame update
    void Start() => rb = GetComponent<Rigidbody>();
    private void Update() => input = Input.GetAxis("Vertical");
    private void FixedUpdate()
    {
        var velocity = rb.velocity;
        velocity.x = transform.forward.x * force * input;
        velocity.z = transform.forward.z * force * input;
        rb.velocity = velocity;
    }
}
