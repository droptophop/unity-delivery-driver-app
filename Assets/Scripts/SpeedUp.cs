using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 25.0f;

    void Update()
    {
        transform.Rotate(0, 0, rotationSpeed);
    }
}
