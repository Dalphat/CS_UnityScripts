using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class IsGrounded : MonoBehaviour
{
    [SerializeField]
    string groundTag = "Ground";
    Jump jump;
    Collider coll;
    private void Start()
    {
        jump = GetComponent<Jump>();
        coll = GetComponent<Collider>();
    }
    private void Update()
    {
        jump.canJump = false;
        var arr = Physics.OverlapSphere(transform.position - Vector3.up * coll.bounds.extents.y, 0.1f);
        foreach (var item in arr)
            if (item.CompareTag(groundTag))
            {
                jump.canJump = true;
                break;
            }
    }
}