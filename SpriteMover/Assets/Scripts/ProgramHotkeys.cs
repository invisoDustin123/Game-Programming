using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgramHotkeys : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //If Space is pushed, the ship sprite will appear in the middle of the screen
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position = new Vector3(0, 0, 0);
        }

        //If P is pushed, the ship will toggle weather it's enabled
        if (Input.GetKey(KeyCode.P))
        {
            GetComponent<ShipMovement>().enabled = !GetComponent<ShipMovement>().enabled;

        }

        //If Esc is pushed, the game will exit
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }

        //If Q is pushed, the ship will be set to inactive
        if (Input.GetKey(KeyCode.Q))
        {
            gameObject.SetActive(false);
        }
    }
}
