using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar : MonoBehaviour {

    public GameObject obj;
    float range = 1.5f;


    private void OnMouseDown ()
    {
       if (gameObject.name == "ClickRight" && obj.transform.position.x < 1.5 )
        {
            obj.transform.Translate(Vector3.right * range);
        }

       if (gameObject.name == "ClickLeft" && obj.transform.position.x > -1.5)
        {
            obj.transform.Translate(-Vector3.right * range);
        }
    }



}
