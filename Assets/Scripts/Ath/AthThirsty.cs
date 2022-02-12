using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using System;

public class AthThirsty : Ath
{
    void Start()
    {
        player = GameObject.Find("User").GetComponent<Player>();
        text = GameObject.FindWithTag("Thirsty_TEXT").GetComponent<Text>();
    }

    void Update()
    {
        float thirsty = player.GetThirsty();
        
        if(thirsty <= end)
        {
            return;
        }

        UpdateTextColor(thirsty, text);

        thirsty -= ((Time.deltaTime * loseSpeed) * lose) ;

        player.SetThirsty(thirsty);

        text.text = $"Besoin de boire {Math.Round((thirsty), 0).ToString()}%";
    }
}
