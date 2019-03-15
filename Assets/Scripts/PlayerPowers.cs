using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPowers : MonoBehaviour {

    string[] powers;
    int currentPower;

    PlayerStats ps;

    UnityEngine.UI.Text powerDisplay;

	// Use this for initialization
	void Start () {
        powers =new string[] { "none","defense","speed","attack"};
        currentPower = 0;
        ps = gameObject.GetComponent<PlayerStats>();
        powerDisplay = GameObject.FindWithTag("PowerDisplay").GetComponent< UnityEngine.UI.Text>();
        powerDisplay.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            changePower(currentPower - 1);
        }

        //back movement
        if (Input.GetKeyDown(KeyCode.E))
        {
            changePower(currentPower + 1);
        }
    }

    void changePower(int pow)
    {
        if (pow >= powers.Length)
        {
            currentPower = 0;
        }
        else if (pow < 0)
        {
            currentPower = powers.Length-1;
        }
        else
        {
            currentPower = pow;
        }
        updateDisplay();
        Debug.Log("Power: " + currentPower);
    }

    void updateDisplay()
    {
        switch (currentPower)
        {
            case 0:
                ps.setSpeed(0.2f);
                ps.setDefense(false);
                break;
            case 1:
                ps.setDefense(true);
                break;
            case 2:
                break;
        }
        powerDisplay.text = "Power: " + powers[currentPower];
        StartCoroutine(fadeDisplay());
    }

    IEnumerator fadeDisplay()
    {
        powerDisplay.enabled = true;
        powerDisplay.color = new Color(powerDisplay.color.r, powerDisplay.color.g, powerDisplay.color.b, 1);
        yield return new WaitForSeconds(3f);
        while (powerDisplay.color.a > 0)
        {
            powerDisplay.color = new Color(powerDisplay.color.r, powerDisplay.color.g, powerDisplay.color.b, powerDisplay.color.a - 0.1f);
            yield return new WaitForSeconds(1f);
        }
        powerDisplay.enabled = false;
    }
}
