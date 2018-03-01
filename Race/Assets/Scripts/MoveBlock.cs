using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlock : MonoBehaviour
{
   // public GameObject obj;
   // private TrackMove trackMove;
   // public float speedBlock;
    public float speedBlockUp ;
    private float poowerUp = 0.01f;
    public float stopMove;
    private int Number = 0;
    
   

    void Start()
    {
        //TimeSpeed = ScreenClick.GetComponent<TimeSpeed>();
        //trackMove = obj.GetComponent<TrackMove>();
       // speedBlock = trackMove.speedTrack;
       // obj.GetComponent<TrackMove>().speedTrack = obj.GetComponent<TrackMove>().speedTrack * speedBlockUp / speedBlock;
        

    }


    void Update()
    {
        if (GameObject.Find("car").GetComponent<Test>().test > Number)
        {
            Number += 1;
            stopMove = 1f;
        }
        else
        {
            stopMove = 0f;
        }

        
        speedBlockUp = (speedBlockUp + poowerUp) - stopMove ;
        transform.Translate(new Vector3(0, -1, 0) * speedBlockUp * Time.deltaTime);
        
        

        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "MainCar")
        {

            col.gameObject.GetComponent<Test>().test += 1f; 
            Destroy(gameObject);

        }
    }



}