﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class UIManager : MonoBehaviour
{
    public GameObject Player;
    public GameObject ScoreOdj, NoBall;
   public int Score;
   float Timer;
   float tempx;
	// Use this for initialization
	void Start () {
        ScoreOdj.SetActive(true);
        tempx = Player.GetComponent<Transform>().position.x;
	}
	
	// Update is called once per frame
	void Update () 
    {
        Timer += Time.deltaTime;
        if (Timer > 1)
        {
            Score = (int)Mathf.Abs(tempx - Player.GetComponent<Transform>().position.x);
            ScoreOdj.GetComponent<Text>().text = Score + "";
            Timer = 0;
        }

      
        
    }

    
}
