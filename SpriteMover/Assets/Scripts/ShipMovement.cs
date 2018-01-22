using UnityEngine;
using System.Collections;

public class ShipMovement : MonoBehaviour
{
    //Declaring the speed variable
    public float speed = 1f;

    void Update()
    {
        //If A is pushed, move the sprite to the left
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        //If D is pushed, move the sprite to the right
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        //If W is pushed, move the sprite up
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        ////If S is pushed, move the sprite down
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
    }
}