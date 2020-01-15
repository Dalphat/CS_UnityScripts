using System;
using UnityEngine;
/*
    Description:
    Looks at the target relative to distance
*/
public class LookAt : MonoBehaviour
{
    [SerializeField] Transform _target;
    [Serializable]
    public class Range {
        public float min, max;
    };
    [SerializeField] Range[] _visibleRanges;
    [SerializeField] float speed;
    void Start()
    {
        if (!_target)
            Destroy(this);
    }
    private void FixedUpdate()
    {
        float distance = (transform.position - _target.position).magnitude;
        foreach (var r in _visibleRanges)
            if ( distance <= r.max && distance >= r.min)
            {
                Vector3 direction = _target.transform.position - transform.position;
                Quaternion rotation = Quaternion.LookRotation(direction);
                transform.rotation = Quaternion.Lerp(
                    transform.rotation, 
                    rotation, 
                    Time.fixedDeltaTime * speed);
                /*
                RaycastHit hit;
                var range = Physics.Raycast(transform.position, transform.forward, out hit, r.max) ? hit.distance : r.max;
                    
                Debug.DrawRay(transform.position, transform.forward * range, Color.green,0.01f, false);
                */
                break;
            }
    }
}
