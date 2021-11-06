using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovement : MonoBehaviour
{
    public float Speed = 25.0f;
    public string axis;
    private void FixedUpdate()
    {
        if (GameManager.SharedInstance.GameStarted == true)
        {
            float v = Input.GetAxisRaw(axis);
            //Debug.Log(v);
            //modificamos la velocidad en el eje Y
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, v * Speed);
        }
    }
}