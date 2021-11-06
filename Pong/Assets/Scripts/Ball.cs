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
    //obtendre informacion del choque de la bola
    //para saber si he chocado con el objeto correcto o no
    //en este caso debo verificar si choca con la pala
    /*
      1 di choca con la parte superior
      0 si choca con el medio
      -1 si choca con la parte inferior
    */
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "PlayerLeft")
        {
            float y = HitFactor(//obtengo la posicion de la bola
                                this.transform.position,
                                //obtengo la posicion de la pala
                                collision.transform.position,
                                //obtengo la altura de la pala
                                collision.collider.bounds.size.y);

            Vector2 Direction = new Vector2(1, y).normalized;
            GetComponent<Rigidbody2D>().velocity = Direction * Speed;
        }
        if (collision.gameObject.name == "PlayerRight")
        {
            float y = HitFactor(//obtengo la posicion de la bola
                                this.transform.position,
                                //obtengo la posicion de la pala
                                collision.transform.position,
                                //obtengo la altura de la pala
                                collision.collider.bounds.size.y);

            Vector2 Direction = new Vector2(-1, y).normalized;
            GetComponent<Rigidbody2D>().velocity = Direction * Speed;
        }
    }
    //metodo que devuelve el factor citado al principio del script
    private float HitFactor(Vector2 BallPosition, Vector2 RacketPosition, float RaquetHeight)
    {
        return (BallPosition.y - RacketPosition.y) / RaquetHeight;
    }
}
