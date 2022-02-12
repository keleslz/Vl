using UnityEngine;
using UnityEngine.UI;

public class Ath : MonoBehaviour
{
    [SerializeField]    
    protected float start = 100f;

    [SerializeField]    
    protected float end = 0f;

    [SerializeField]
    protected float lose = 0.001f;

    [SerializeField]
    protected float loseSpeed = 10f;

    protected Text text;

    protected Player player;

    protected void UpdateTextColor(float currentValue, Text text)
    {
        if((currentValue <= start) && (currentValue > (start / 2f)) )
        {
            text.color = Color.black;
        }

        if(currentValue <= (start / 2f) )
        {
            text.color = Color.yellow;
        }
        
        if(currentValue <= (start / 3f) )
        {
            text.color = Color.red;
        }
    }
}
