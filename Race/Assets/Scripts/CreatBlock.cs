using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatBlock : MonoBehaviour {

    public GameObject block;
    public Vector3[] positions;
    public float delayTime = 1f;
    float timer;
    


    void Start () {

        timer = delayTime;
	}
	
	
	void Update () {


        //timer = delayTime;
        timer -= Time.deltaTime;

        if (timer <= 0)
        {

            int RandomNumber = Random.Range(1, 3);
            transform.position = positions[RandomNumber];

            Instantiate(block, transform.position, transform.rotation);
            if (delayTime > 2)
            {
                delayTime -= 0.25f;
                timer = delayTime;
            } else
            {
                delayTime = 2f;
                timer = delayTime;
            }
            
            
        }

     


    }


}
