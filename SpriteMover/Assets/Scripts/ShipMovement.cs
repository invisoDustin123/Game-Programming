using UnityEngine;
using System.Collections;

public class ShipMovement : MonoBehaviour
{
    //Declaring the speed variable
    public float speed = 1f;

    void Update()
    {
        //If Left is pushed, move the sprite to the left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        //If Right is pushed, move the sprite to the right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        //If Up is pushed, move the sprite up
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        ////If Down is pushed, move the sprite down
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
    }
}