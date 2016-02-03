﻿using UnityEngine;
using System.Collections;

public class SignalRotate : MonoBehaviour {

	// Use this for initialization
	public bool m_QuadEmpty = false;
	void Update()
	{
		if (m_QuadEmpty == false)
			transform.Rotate (new Vector3 (15, 45, 15) * Time.deltaTime);
		else
			transform.Rotate (new Vector3 (90, 180, 90));
	}

}
