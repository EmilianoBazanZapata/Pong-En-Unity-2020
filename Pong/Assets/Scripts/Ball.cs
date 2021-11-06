using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float Speed = 25.0f;
    private void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * Speed;
    }
}
