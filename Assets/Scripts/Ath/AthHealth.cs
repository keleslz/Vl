using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using System;

public class AthHealth : Ath
{
    void Start()
    {
        player = GameObject.Find("User").GetComponent<Player>();
        text = GameObject.FindWithTag("Health_TEXT").GetComponent<Text>();
    }

    void Update()
    {
        float health = player.GetHealth();

        if(health <= end)
        {
            return;
        }

        UpdateTextColor(health, text);

        health -= ((Time.deltaTime * loseSpeed) * lose) ;

        player.SetHealth(health);

        text.text = $"Santé {Math.Round((health), 0).ToString()}/100";

    }
}
