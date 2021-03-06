﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour {

    private const float Y_ANGLE_MIN = 0.0F;
    private const float Y_ANGLE_MAX = 50.0f;

    public Transform lookAt;
    public Transform camTransform;

    private Camera cam;

    private float distance = 10.0f;
    private float currentX = 0.0f;
    private float currentY = 0.0f;
    private float sensitivityX = 0.0f;
    private float sensitivityY = 0.0f;

	// Use this for initialization
	private void Start () {
        camTransform = transform;
        lookAt = GameObject.Find("CamLookAtPos").transform;
        cam = Camera.main;
	}

    private void Update()
    {
        currentX += Input.GetAxis("Mouse X")*2;
        currentY += Input.GetAxis("Mouse Y");

        currentY = Mathf.Clamp(currentY, Y_ANGLE_MIN, Y_ANGLE_MAX);
    }

    // Update is called once per frame
    private void LateUpdate () {
        Vector3 dir = new Vector3(0, 0, -distance);
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        camTransform.position = lookAt.position + rotation * dir;
        camTransform.LookAt(lookAt.position);
	}

    
}
