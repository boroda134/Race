using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatBlock2 : MonoBehaviour {
    public GameObject car;
    public Vector3[] positions;
    public float delayTime = 1f;
    float timer;


    void Start()
    {
        timer = delayTime;
    }


    void Update()
    {

        timer -= Time.deltaTime;

        if (timer <= 0)
        {

            int RandomNumber = Random.Range(0, 1);
            transform.position = positions[RandomNumber];

            Instantiate(car, transform.position, transform.rotation);
            timer = delayTime;
        }




    }

}
