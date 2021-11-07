using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager SharedInstance = null;
    public bool GameStarted = false;
    public Text Title;
    public Button StartButton;
    public GameObject ball;
    private Vector2 NextDirection;
    private void Awake()
    {
        if (SharedInstance == null)
        {
            SharedInstance = this;
        }
    }
    public void StartGame()
    {
        this.GameStarted = true;
        this.Title.enabled = false;
        this.StartButton.gameObject.SetActive(false);
    }
    public void ScoreGoal()
    {
        ball.transform.position = Vector3.zero;
        NextDirection = new Vector2(-ball.GetComponent<Rigidbody2D>().velocity.x, 0);
        ball.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        Invoke("LaunchBall", 2.0f);
    }
    private void LaunchBall()
    {
        Ball b = ball.GetComponent<Ball>();
        ball.GetComponent<Rigidbody2D>().velocity = NextDirection.normalized * b.Speed;
    }
    public void Exit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}