using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controls : MonoBehaviour
{
    [SerializeField] Transform plane;
    [SerializeField] float rotateXSpeed;  // renamed from pitchSpeed
    [SerializeField] float rotateZSpeed;  // renamed from yawSpeed

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotateX = Input.GetAxisRaw("Vertical") * rotateXSpeed * Time.deltaTime;    // Up/Down arrows
        float rotateZ = -Input.GetAxisRaw("Horizontal") * rotateZSpeed * Time.deltaTime;  // Left/Right arrows

        plane.Rotate(rotateX, 0, rotateZ);  // Changed to use X and Z rotation
    }
}

