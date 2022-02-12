using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    public static PlayerActions actions = new PlayerActions();

    void Start()
    {
        id = 1;
        ethnicGroup = Character.Types.Vampyr;
        username = "Slz";
    }
}
