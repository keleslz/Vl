using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRaycast : MonoBehaviour
{
    public static bool isCollision;
    
    public RaycastHit hit;

    public static GameObject target;

    [SerializeField]
    private GameObject currentTarget;

    void FixedUpdate()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        
        if (Physics.Raycast(transform.position, fwd, out hit, 2.5f)) {
            isCollision = true;

            if(hit.collider != null)
            {
                target = hit.collider.gameObject; 
                currentTarget = target;
            }
        }else {
            isCollision = false;
            if(target)
            {
                target = null; 
                currentTarget = target;
            }
        }
    }
}
