using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] float destroySpeed = 0.5f;
    [SerializeField] Color32 enrouteColor = new Color32(25, 255, 1, 255);
    [SerializeField] Color32 notEnrouteColor = new Color32(226, 199, 1, 255);

    private SpriteRenderer spriteRenderer;

    private bool enroute = false;
    private bool delivered;

    private void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("I'm hit!");
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Package" && !enroute) {
            enroute = true;
            delivered = false;
            spriteRenderer.color = enrouteColor;
            Destroy(other.gameObject, destroySpeed);
            Debug.Log("Package Picked Up");
        }

        if(other.tag == "DeliveryDestination" && enroute) {
            enroute = false;
            delivered = true;
            spriteRenderer.color = notEnrouteColor;
            Debug.Log("Package Delivered");
        }
    }
}
