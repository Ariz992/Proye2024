using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class raycastInteraction : MonoBehaviour
{
    public float RayLenght;
    public Transform RayOrigin;
    public LayerMask LayerMask;
    public GameObject hint;
    public CartelData cartel;
    // Start is called before the first frame update
    void Start()
    {
        hint.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit hit;
        if (Physics.Raycast(RayOrigin.position, RayOrigin.forward, out hit, RayLenght, LayerMask))
        {
            Debug.Log("hit con " + hit.collider.name);
            cartel = hit.collider.GetComponent<CartelData>();
            hint.SetActive(true);
            hint.GetComponent<Text>().text = cartel.mensaje;
        }
        else
        {
            hint.SetActive(false);
        }

    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(RayOrigin.position, RayOrigin.position + RayOrigin.forward * RayLenght);
    }
}       
    