using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {
	Text test = null;
	// Use this for initialization
	void Start () {
		test = GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {

	}

	public void UpdateTextTo( )
	{
		test.text = "Part Selected: ";
	}
}
