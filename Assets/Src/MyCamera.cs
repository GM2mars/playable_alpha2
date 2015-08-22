﻿using UnityEngine;
using System.Collections;

public class MyCamera : MonoBehaviour {
	public float mouseSensitivity = 0.01f;
	private Vector3 lastPosition;

	// Use this for initialization
	void Start () {
		//main = this;
	}
	
	// Update is called once per frame
	void Update () {
		//Camera.main.ScreenToWorldPoint(Input.mousePosition) 

		if (Input.GetMouseButtonDown(2))
		{
			lastPosition = Input.mousePosition;
		}

		if (Input.GetMouseButton(2))
		{
			Vector3 delta = lastPosition - Input.mousePosition;
			transform.Translate(delta.x * mouseSensitivity, delta.y * mouseSensitivity, 0);

			//var ms_world = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			//transform.position = new Vector3(ms_world.x, ms_world.y, -10);
			lastPosition = Input.mousePosition;
		}
	}
}