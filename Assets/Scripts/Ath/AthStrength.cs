using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using System;

public class AthStrength : Ath
{
    void Start()
    {
        player = GameObject.Find("User").GetComponent<Player>();
        text = GameObject.FindWithTag("Strength_TEXT").GetComponent<Text>();
    }

    void Update()
    {
        float strength = player.GetStrength();

        if(strength <= end)
        {
            return;
        }

        UpdateTextColor(strength, text);

        strength -= ((Time.deltaTime * loseSpeed) * lose) ;

        player.SetStrength(strength);

        text.text = $"Energie {Math.Round((strength), 0).ToString()}/100";
    }
}
