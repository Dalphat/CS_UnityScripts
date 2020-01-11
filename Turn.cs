using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class Turn : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] private float speed = 1f;
    [HideInInspector] public Vector3 velocity;
    void Start() => rb = GetComponent<Rigidbody>();
    private void Update() => velocity.y = Input.GetAxis("Horizontal") * speed;
    private void FixedUpdate() => rb.rotation = Quaternion.Euler(rb.rotation.eulerAngles + velocity);
}
