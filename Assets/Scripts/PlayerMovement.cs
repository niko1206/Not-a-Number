using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    PlayerStats ps;

	// Use this for initialization
	void Start () {
        ps = gameObject.GetComponent<PlayerStats>();
        ps.setSpeed(0.1f);
	}
	
	// Update is called once per frame
	void Update () {

        //front movement
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, ps.getSpeed());
        }

        //back movement
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -ps.getSpeed());
        }

        //left movement
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-ps.getSpeed(), 0, 0);
        }

        //right movement
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(ps.getSpeed(), 0, 0);
        }

    }
}
