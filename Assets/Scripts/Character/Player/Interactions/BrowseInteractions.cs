using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrowseInteractions : MonoBehaviour
{
    public Text[] choices; 

    public GameObject container;

    public int indexSelection;

    public int startIndex = 0;

    private bool actionInProgess = false;

    void Start()
    {
        container = GameObject.FindWithTag("Interactions_CHOICES");

        if(!container) return;

        choices = new Text[container.transform.childCount];

        for(int i = 0; i < container.transform.childCount; i++)
        {
            Transform child = container.transform.GetChild(i);
            Text choice = child.GetComponentInChildren<Text>(); 

            choices[i] = choice;
        }

        indexSelection = startIndex;

        choices[indexSelection].color = Color.blue;
    }

    void Update()
    {
        if(!Interactions.isActive) return;

        IsCancel();
        IsDrink();

        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            indexSelection+=1;

            if(indexSelection == choices.Length)
            {
                indexSelection = startIndex;

                choices[indexSelection].color = Color.blue;
                choices[choices.Length-1].color = Color.black;
            }else {
                choices[indexSelection].color = Color.blue;
                choices[indexSelection-1].color = Color.black;
            }
        }

        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            indexSelection-=1;

            if(indexSelection < 0)
            {
                indexSelection = choices.Length -1;

                choices[indexSelection].color = Color.blue;
                choices[startIndex].color = Color.black;
            }else {
                choices[indexSelection].color = Color.blue;
                choices[indexSelection+1].color = Color.black;
            }
        }

        if(actionInProgess)
        {
            actionInProgess = false;
        }
    }

    void IsCancel()
    {
        if(Input.GetKeyDown(KeyCode.X) && indexSelection == choices.Length-1 && !actionInProgess)  // Cancel
        {
            HandleActionInProgress();
            Interactions.UpdateIsActive(false);
            choices[indexSelection].color = Color.black;
            indexSelection -= indexSelection;
            choices[startIndex].color = Color.blue;
            Debug.Log("J'annule");
        }
    }

    void IsDrink()
    {
        if(Input.GetKeyDown(KeyCode.X) && indexSelection == 0 && !actionInProgess) // Cancel
        {
            HandleActionInProgress();
            Interactions.UpdateIsActive(false);
            choices[indexSelection].color = Color.black;
            indexSelection -= indexSelection;
            choices[startIndex].color = Color.blue;
            Debug.Log("je bois");
        }
    }

    void HandleActionInProgress()
    {
        actionInProgess = true;
    }
}
