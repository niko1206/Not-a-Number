using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    public float speed;
    float health;
    bool defense;
    bool attack;
    int maxJumps;

    // Use this for initialization
    void Start () {
        health = 100;
        maxJumps = 1;
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

    public void setAttack(bool att)
    {
        attack = att;
    }

    public bool getAttack()
    {
        return attack;
    }

    public void setMaxJumps(int _mj)
    {
        maxJumps = _mj;
    }

    public int getMaxJumps()
    {
        return maxJumps;
    }
}
