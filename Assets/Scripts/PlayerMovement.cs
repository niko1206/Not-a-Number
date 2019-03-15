using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    PlayerStats ps;
    int currentJumps;
    public float jumpForce = 400f;
    Vector3 jumpHeight = new Vector3(0, 3f, 0);

    Rigidbody rb;


	// Use this for initialization
	void Start () {
        ps = gameObject.GetComponent<PlayerStats>();
        ps.setSpeed(0.1f);
        rb = GetComponent<Rigidbody>();
        currentJumps = 1;
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

        //left movement
        if (Input.GetKeyDown(KeyCode.Space)&&currentJumps>0)
        {
           currentJumps--;
            rb.AddForce(jumpHeight*jumpForce);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collided with: " + collision.gameObject.name);
        currentJumps = ps.getMaxJumps();
    }


}
