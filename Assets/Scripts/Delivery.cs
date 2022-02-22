using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] float destroySpeed = 0.5f;

    private bool enroute = false;
    private bool delivered;

    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("I'm hit!");
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Package" && !enroute) {
            enroute = true;
            delivered = false;
            Destroy(other.gameObject, destroySpeed);
            Debug.Log("Package Picked Up");
        }

        if(other.tag == "DeliveryDestination" && enroute) {
            enroute = false;
            delivered = true;
            Debug.Log("Package Delivered");
        }
    }
}
