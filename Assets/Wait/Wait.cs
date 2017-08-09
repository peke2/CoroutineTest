using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wait : MonoBehaviour {

	GameObject textObj;
	GameObject buttonObj;

	// Use this for initialization
	void Start () {
		textObj = GameObject.Find("MessageText");
		buttonObj = GameObject.Find("Button");
		buttonObj.GetComponent<Button>().onClick.AddListener(onClick);
	
		StartCoroutine(waitProc());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	bool isEnd;
	IEnumerator waitProc()
	{
		string text = "処理中";

		int count = 0;

		Text tcomp = textObj.GetComponent<Text>();

		isEnd = false;
		while( false == isEnd )
		{
			count++;

			int plus = (count / 15) % 6;
			string t = text;

			for(int i=0; i<plus; i++)
			{
				t += ".";
			}

			tcomp.text = t;
			yield return null;
		}
	
		tcomp.text = "処理終了";
	}


	void onClick()
	{
		Debug.Log("ボタン押された");
		isEnd = true;
	}

}
