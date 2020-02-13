using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//得点を表示しよう

public class ScoreController : MonoBehaviour
{
    private GameObject scoreText;

    private int score = 0;

	void Start ()
    {
        this.scoreText = GameObject.Find("ScoreText");
	}
	
	void Update ()
    {
		
	}

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "SmallStarTag")
        {
            point(1);
        }
        else if (other.gameObject.tag == "LargeStarTag")
        {
            point(5);
        }
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            point(10);
        }
        else if (other.gameObject.tag == "LareCloudrTag")
        {
            point(30);
        }
    }

    void point(int a)
    {
        score += a;
        this.scoreText.GetComponent<Text>().text = "Score:" + score.ToString("D4");
    }
}
