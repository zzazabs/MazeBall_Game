﻿using UnityEngine;
using System.Collections;

public class LoadonClick : MonoBehaviour {

	public void LoadScene(int level)
	{
		Application.LoadLevel(level);
	}
}
