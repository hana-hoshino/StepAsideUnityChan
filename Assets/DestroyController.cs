using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyController : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		//this.transformで自分自身の位置取得、カメラの位置より小さくなった場合にGameObjectDestroyを呼ぶ
		if (this.transform.position.z < Camera.main.gameObject.transform.position.z)
        {
			//カメラに写っていないオブジェクトを消す
			Debug.Log("カメラに写っていないオブジェクトが消えました");
			GameObject.Destroy(this.gameObject);

		}

	}

}
