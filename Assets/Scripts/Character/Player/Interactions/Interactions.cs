using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactions : MonoBehaviour
{
    public static GameObject container;

    public static bool isActive;

    enum Options {
        Cancel,
        Drink
    }

    // public static string[] choicesAvailable = new string[] {"Drink", "Discuter", "Tuer", "Cancel"};

    void Start()
    {
        container = GameObject.FindWithTag("InteractionsParent");
        if(!container) return;

        // GenerateChoice();
        OpenClose();
    }

    void Update()
    {
        if(!container || isActive) return; // After openning, must be close with call "UpdateIsActive" method

        if(Input.GetKeyDown(KeyCode.Space))
        {
            OpenClose();
        }   
    }

    /**
    * Open/Close Interactions
    */
    void OpenClose()
    {
        if(container.activeSelf)
        {
            container.SetActive(false);
            isActive = false;
        }else {
            container.SetActive(true);
            isActive = true;
        }
    }

    public static bool UpdateIsActive(bool _isActive)
    {
        if(!container) return false;
        
        container.SetActive(_isActive);
        return isActive = _isActive;
    }

    //Generate choice dynamically thanks to "choicesAvailable" list 
    /* void GenerateChoice()
    {
        Transform choicesContainer = container.transform.GetChild(1);

        Debug.Log(choicesContainer.childCount);

        float firstElementPosY = -338.5f;

        // for(int i = 0; i < choicesAvailable.Length; i++)
        {
            // Debug.Log(choicesAvailable[i].GetType());
            
            string choice = choicesAvailable[i];
            
            GameObject go = new GameObject();
            go.name = choice;  



            GameObject panelContainer = new GameObject();
            panelContainer.name = "OptionPanelList";

            RectTransform rt = panelContainer.AddComponent<RectTransform>();

            Canvas c = panelContainer.AddComponent<Canvas>();
            c.renderMode = RenderMode.ScreenSpaceOverlay;

            GraphicRaycaster gr = panelContainer.AddComponent<GraphicRaycaster>();
            
            GameObject panel = new GameObject();
            panel.name = "Panel";
            panel.transform.position = new Vector3(235, firstElementPosY, 0); 

            RectTransform rtPanel = panel.AddComponent<RectTransform>();
            rtPanel.anchoredPosition = new Vector3(0,0);
            
            CanvasRenderer cPanel = panel.AddComponent<CanvasRenderer>();
            Image image = panel.AddComponent<Image>();
                // Faire appari les options dynmiquement
            
            GameObject textContainer = new GameObject();
            textContainer.name = "Text" + choice;

            GameObject text = new GameObject();
            text.name = "Text";

            RectTransform rtText = text.AddComponent<RectTransform>();
            CanvasRenderer cText = text.AddComponent<CanvasRenderer>();
            Text t = text.AddComponent<Text>();

            if(i == choicesAvailable.Length - 1)
            {
                t.text =  $"X - {char.ToUpper(choice[0]) + choice.Substring(1)}";
            }else {
                t.text =  $"{i} - {char.ToUpper(choice[0]) + choice.Substring(1)}";
            }




            go.transform.parent = choicesContainer;

            panelContainer.transform.parent = go.transform;
            textContainer.transform.parent = go.transform;

            panel.transform.parent = panelContainer.transform;
            text.transform.parent = textContainer.transform; 
        }
    } */
}
