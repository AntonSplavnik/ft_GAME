﻿using Manager;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "obstalce")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    } 
}
