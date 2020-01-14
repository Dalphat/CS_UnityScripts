using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    [SerializeField] Transform _target;

    void Start()
    {
        if (!_target)
            Destroy(this);
    }
    private void FixedUpdate() => transform.LookAt(_target);
}
