using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovement : MonoBehaviour
{
    public float Speed = 25.0f;
    private void FixedUpdate() {
        float v = Input.GetAxisRaw("Vertical");
        //Debug.Log(v);
        //modificamos la velocidad en el eje Y
        GetComponent<Rigidbody2D>().velocity = new Vector2(0,v * Speed);
    }
}