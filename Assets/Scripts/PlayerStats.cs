using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    float speed;
    float health;
    bool defense;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void setSpeed(float _speed)
    {
        speed = _speed;
    }

    public float getSpeed()
    {
        return speed;
    }

    public void setHealth(float _health)
    {
        health = _health;
    }

    public float getHealth()
    {
        return health;
    }

    public void setDefense(bool def)
    {
        defense = def;
    }

    public bool getDefense()
    {
        return defense;
    }
}
