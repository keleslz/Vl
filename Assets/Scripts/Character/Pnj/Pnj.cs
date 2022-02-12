using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Pnj : Character
{
    private static int instantiationCount = 2; // Player has first id

    void Start()
    {
        id = instantiationCount;
        instantiationCount+=1;

        if(instantiationCount % 6 == 0)
        {
            ethnicGroup = Character.Types.Vampyr;
        }else {
            ethnicGroup = Character.Types.Human;
        }

        username = "Pnj n° " + id;
    }
}
