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
}