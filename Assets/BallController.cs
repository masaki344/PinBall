using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    private float visiblePosz = -6.5f;

    private GameObject gameoverText;

	void Start ()
    {
        this.gameoverText = GameObject.Find("GameOverText");
	}
	
	void Update ()
    {
        if (this.transform.position.z < visiblePosz)
        {
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }

	}
}
