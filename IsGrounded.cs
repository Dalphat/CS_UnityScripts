using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Collider))]
public class IsGrounded : MonoBehaviour
{
    [SerializeField] private float dist = 0.1f;
    [HideInInspector] public bool grounded;
    Collider col;

    private void Start() => col = GetComponent<Collider>();
    private void Update() => grounded = Physics.Raycast(transform.position, Vector3.down, col.bounds.extents.y + dist);
}
