using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kostyl : MonoBehaviour
{

    public Vector3 positions;


    void Start()
    {

    }


    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy Block")
        {
            collision.gameObject.transform.position = positions;
        }
    }
}