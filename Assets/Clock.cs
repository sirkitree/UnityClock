﻿using System;
using UnityEngine;

public class Clock : MonoBehaviour {

	const float 
		degreesPerHour = 30f,
		degreesPerMinute = 6f,
		degreesPerSecond = 6f;

	public Transform hoursTransform, minutesTransform, secondsTransform;

	void Update () {
		// Debug.Log (DateTime.Now.Hour);
		DateTime time = DateTime.Now;
		hoursTransform.localRotation =
			Quaternion.Euler(0f, time.Hour * degreesPerHour, 0f);
		minutesTransform.localRotation =
			Quaternion.Euler(0f, time.Minute * degreesPerMinute, 0f);
		secondsTransform.localRotation =
			Quaternion.Euler(0f, time.Second * degreesPerSecond, 0f);
	}
}