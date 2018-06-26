using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.UI;

public class canvasupdate : MonoBehaviour
{
	public Text CurrentColor;
	
	// Update is called once per frame
	void Update ()
	{
		CurrentColor.text = Global.CurrentColor;
	}
}
