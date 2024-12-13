using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycastInteraction : MonoBehaviour
{
    public float RayLenght;
    public Transform RayOrigin;
    public LayerMask LayerMask;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit hit;
        if (Physics.Raycast(RayOrigin.position, RayOrigin.forward, out hit, RayLenght, LayerMask))
        {
            Debug.Log("hit con " + hit.collider.name);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(RayOrigin.position, RayOrigin.position + RayOrigin.forward * RayLenght);
    }
}       
    