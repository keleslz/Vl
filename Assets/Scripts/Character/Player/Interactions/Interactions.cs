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

    void Start()
    {
        container = GameObject.FindWithTag("InteractionsParent");
        if(!container) return;

        OpenClose();
    }

    void Update()
    {
        if(!container || isActive) return; // After openning, must be close with call "UpdateIsActive" method

        if(Input.GetKeyDown(KeyCode.Space) && PlayerRaycast.isCollision)
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
}
