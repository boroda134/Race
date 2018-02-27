using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlock : MonoBehaviour {

    public float speed = 10f;


	void Start () {
		
	}
	
	
	void Update () {
        transform.Translate(new Vector3(0, -1, 0) * speed * Time.deltaTime);
	}
}
