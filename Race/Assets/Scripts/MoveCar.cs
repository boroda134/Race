using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar : MonoBehaviour {

    public GameObject obj;
    public float range = 2f;
   // private float stop;

    private void OnMouseUpAsButton()
    {
      
        
            if (gameObject.name == "ClickRight" && obj.transform.position.x < 2)
            {
                obj.transform.Translate(Vector3.right * range);
             //   stop = stop + range;
            }

            if (gameObject.name == "ClickLeft" && obj.transform.position.x > -2)
            {
                obj.transform.Translate(-Vector3.right * range);
              //  stop = stop - range;
            }

    }

}
