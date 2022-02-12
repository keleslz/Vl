using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using System;

public class AthThirsty : MonoBehaviour
{
    [SerializeField]
    private float startThirsty = 0f;

    [SerializeField]
    private float thirsty;

    [SerializeField]
    private float gain = 0.001f;

    [SerializeField]
    private float speedGain = 10f;

    private Text text;

    void Start()
    {
        thirsty = startThirsty;
        text = GameObject.FindWithTag("Thirsty_TEXT").GetComponent<Text>();
    }

    void Update()
    {
        if(thirsty >= 100f)
        {
            thirsty = 0f;
            return;
        }

        if((thirsty >= 0f) && (thirsty < 50f) )
        {
            text.color = Color.black;
        }

        if(thirsty >= 50f )
        {
            text.color = Color.yellow;
        }

        if(thirsty >= 70f )
        {
            text.color = Color.red;
        }

        thirsty += ((Time.deltaTime * speedGain) * gain) ;
        text.text = $"Besoin de boire {Math.Round((thirsty), 0).ToString()}% ";
    }
}
