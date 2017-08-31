using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetDestroy : MonoBehaviour {

	//	Coroutineが動いている対象を破棄したらどうなるか？
	//	【結果】オブジェクトが破棄されてCoroutineの処理も止まる
	//	独立した処理としてCoroutineを動かしている時に、所属元のMonoBehaviourを破棄すると止まる
	//	処理が動いている間は残り続けるかと思ったけど、そんなことは無かった

	public GameObject target;

	// Use this for initialization
	void Start () {
		Button btn = transform.GetComponent<Button>();
		btn.onClick.AddListener(onButtonClick);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void onButtonClick()
	{
		if( null == target )	return;

		GameObject.Destroy(target);
		target = null;
	}
}
