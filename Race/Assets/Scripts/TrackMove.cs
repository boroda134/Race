using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackMove : MonoBehaviour {

    public float StandartSpeedTrack = 0.5f;
    public float speedTrack;
    Vector2 offset;
    

    void Start () {
		
	}
	
	void Update () {
        speedTrack = (GameObject.Find("block_01").GetComponent<MoveBlock>().speedBlockUp * StandartSpeedTrack)/ 10;


        offset = new Vector2(0, Time.time * speedTrack);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
		
	}

   
           
        

    
}
