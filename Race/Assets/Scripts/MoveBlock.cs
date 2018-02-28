using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlock : MonoBehaviour
{
   // public GameObject obj;
    private TrackMove trackMove;
   // public float speedBlock;
    public float speedBlockUp ;
    private float poowerUp = 0.01f;
   

    void Start()
    {
        //TimeSpeed = ScreenClick.GetComponent<TimeSpeed>();
        //trackMove = obj.GetComponent<TrackMove>();
       // speedBlock = trackMove.speedTrack;
       // obj.GetComponent<TrackMove>().speedTrack = obj.GetComponent<TrackMove>().speedTrack * speedBlockUp / speedBlock;
        

    }


    void Update()
    {
        speedBlockUp += poowerUp;
        transform.Translate(new Vector3(0, -1, 0) * speedBlockUp * Time.deltaTime);
  
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "MainCar")
        {
            Destroy(gameObject);
        }
    }



}