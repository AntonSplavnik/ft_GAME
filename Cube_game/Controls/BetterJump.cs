using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterJump : MonoBehaviour
{
    public float jumpVelocity = 10f;
    public float foallMultiplayer = 2.5f;
    public float lowJumpMultiplayer = 2f;

    Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
   
    void Update()
    {
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (foallMultiplayer - 1) * Time.deltaTime;

        }
        else if (rb.velocity.y > 0 & !Input.GetButton("Jump"))
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (lowJumpMultiplayer - 1) * Time.deltaTime;
        }


    }

    private void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody>().velocity = Vector3.up * jumpVelocity;
        }

    }


}
