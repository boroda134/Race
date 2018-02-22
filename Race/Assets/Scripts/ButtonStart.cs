using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonStart : MonoBehaviour {

    private void OnMouseUpAsButton()
    {
        switch (gameObject.name)
        {
            case "b_Start":
                Application.LoadLevel("menu");
                break;

            case "play_Easy":
                Application.LoadLevel("gameEasy3x3");
                break;

        }
    }
}
