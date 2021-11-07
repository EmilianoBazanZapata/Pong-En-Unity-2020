using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GoalZone : MonoBehaviour
{
    public Text ScoreText;
    private int Score;
    private void Awake()
    {
        this.Score = 0;
        this.ScoreText.text = Score.ToString();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ball")
        {
            //Debug.Log("alguien marco un gol");
            this.Score += 1;
            this.ScoreText.text = Score.ToString();
            GameManager.SharedInstance.ScoreGoal();
        }
    }
}
