using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour {
	public static readonly float MOVE_SPEED = 0.2f;
	public static readonly float ROT_SPEED = 2f;

	private GameObject _core;

	// Use this for initialization
	void Start () {
		_core = GameObject.Find("Core").gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		//移動
		if(Input.GetKey(KeyCode.W)){
			transform.Translate(0, 0, MOVE_SPEED);
		}

		if(Input.GetKey(KeyCode.S)){
			transform.Translate(0, 0, -MOVE_SPEED);
		}

		//機体の回転
		if(Input.GetKey(KeyCode.A)){
			transform.Rotate(0, -ROT_SPEED, 0);
		}

		if(Input.GetKey(KeyCode.D)){
			transform.Rotate(0, ROT_SPEED, 0);
		}
	}
}
