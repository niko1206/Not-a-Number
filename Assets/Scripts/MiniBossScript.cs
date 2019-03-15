using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniBossScript : MonoBehaviour {

    public int health;
    public PlayerStats ps;

	// Use this for initialization
	void Start () {
        health = 100;
        ps = GameObject.FindWithTag("Player").GetComponent<PlayerStats>();
	}
	
	// Update is called once per frame
	void Update () {
        if (ps.getAttack())
        {
            health -= 2;
        }
        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
	}
}
