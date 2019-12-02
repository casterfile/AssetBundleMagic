using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OutputTest : MonoBehaviour {
	int i = 0;
	public Text OutputDAta;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		i = i + 1;
		OutputDAta.text = "OutputDAta: "+i;
	}
}
