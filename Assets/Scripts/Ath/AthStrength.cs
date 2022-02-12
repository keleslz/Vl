using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using System;

public class AthStrength : MonoBehaviour
{
    [SerializeField]
    private float startStrength = 100f;

    [SerializeField]
    private float strength;

    [SerializeField]
    private float lose = 0.001f;

    [SerializeField]
    private float loseSpeed = 10f;

    private Text text;

    void Start()
    {
        strength = startStrength;
        text = GameObject.FindWithTag("Strength_TEXT").GetComponent<Text>();
    }

    void Update()
    {
        if(strength <= 0)
        {
            strength = startStrength;
            return;
        }

        if((strength <= startStrength) && (strength > (startStrength / 2f)) )
        {
            text.color = Color.black;
        }

        if(strength <= (startStrength / 2f) )
        {
            text.color = Color.yellow;
        }
        
        if(strength <= (startStrength / 3f) )
        {
            text.color = Color.red;
        }

        strength -= ((Time.deltaTime * loseSpeed) * lose) ;
        text.text = $"Energie {Math.Round((strength), 0).ToString()}/100";
    }
}
