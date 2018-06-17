using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine(DeadCount());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//死亡カウンター
	IEnumerator DeadCount(){
		//3秒数える
		yield return new WaitForSeconds(5f);

		Destroy(this.gameObject);
	}

	//当たった瞬間に呼ばれる
	private void OnCollisionEnter(Collision other) {
		//当たったら消える
		if(other.gameObject.tag == "Enemy"){
			Destroy(other.gameObject);
		}
	}
}
