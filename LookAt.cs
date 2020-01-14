using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    [SerializeField] Transform target;
    void Start()
    {
        if (!target)
            Destroy(this);
    }
    private void FixedUpdate() => transform.LookAt(target);
}
