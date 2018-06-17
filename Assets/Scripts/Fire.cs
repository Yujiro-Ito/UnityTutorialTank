using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {
	public static readonly float ROT_SPEED = 2f;
	public static readonly float FORCE = 50f;

	public GameObject BulletPrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//砲塔の回転
		if(Input.GetKey(KeyCode.UpArrow)){
			transform.Rotate(-ROT_SPEED, 0, 0);
		}

		if(Input.GetKey(KeyCode.DownArrow)){
			transform.Rotate(ROT_SPEED, 0, 0);
		}

		//弾発射
		if(Input.GetKeyDown(KeyCode.Space)){
			GameObject obj = (GameObject)Instantiate(BulletPrefab, transform.position, Quaternion.identity);
			obj.GetComponent<Rigidbody>().AddForce(transform.forward * FORCE, ForceMode.Impulse);
		}
	}
}
