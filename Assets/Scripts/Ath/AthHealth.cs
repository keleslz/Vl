using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using System;

public class AthHealth : MonoBehaviour
{
    [SerializeField]
    private float startHealth = 100f;

    [SerializeField]
    private float health;

    [SerializeField]
    private float lose = 0.001f;

    [SerializeField]
    private float loseSpeed = 10f;

    private Text text;

    void Start()
    {
        health = startHealth;
        text = GameObject.FindWithTag("Health_TEXT").GetComponent<Text>();
    }

    void Update()
    {
        if(health <= 0)
        {
            health = startHealth;
            return;
        }

        if((health <= startHealth) && (health > (startHealth / 2f)) )
        {
            text.color = Color.black;
        }

        if(health <= (startHealth / 2f) )
        {
            text.color = Color.yellow;
        }
        
        if(health <= (startHealth / 3f) )
        {
            text.color = Color.red;
        }

        health -= ((Time.deltaTime * loseSpeed) * lose) ;
        text.text = $"Santé {Math.Round((health), 0).ToString()}/100";

    }
}
