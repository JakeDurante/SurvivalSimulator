﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DropdownFix : MonoBehaviour {
	class DropdownPausedFixer : MonoBehaviour
	{
		void Awake()
		{
			GetComponent<Dropdown>().onValueChanged.AddListener(value => Destroy(transform.Find("Dropdown List").gameObject));
		}
	}
}