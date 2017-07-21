using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateX : MonoBehaviour {

    int proc_count = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (proc_count == 0)
        {
            IEnumerator proc = run();
            StartCoroutine(proc);

            Debug.Log("X回転終了");
        }

		//	コルーチン実行中も Update() の処理は実行を続ける
		//	yield で関数のワークが保持されるので、それをフックして別途呼び出している？
		//	デバッガで確認すると Update() も コルーチンもスレッドID 1から呼ばれていた
        proc_count++;
        if( (proc_count % 60) == 0 )
        {
            Debug.Log((proc_count / 60).ToString() +"秒経過");
        }
    }

    IEnumerator run()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            for (int i = 0; i < 180; i++)
            {
				//	MonoBehaviourのどこかにフックされて毎フレーム呼ばれている？
                //yield return new WaitForSeconds(0.016f);
				yield return null;
                transform.Rotate(1, 0, 0);
            }
        }    
    }
}
