using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Routine : MonoBehaviour {

	Text text;

	// Use this for initialization
	void Start () {
		text = transform.Find("Text").GetComponent<Text>();
		StartCoroutine(counter());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator counter()
	{
		int  time = 0;

		while(true)
		{
			text.text = time.ToString();
			yield return new WaitForSeconds(1);
			Debug.Log(time);
			time += 1;
		}
	}
}
