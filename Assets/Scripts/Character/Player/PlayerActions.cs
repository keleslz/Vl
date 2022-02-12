using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions
{
    public void Drink()
    {
        GameObject target = PlayerRaycast.target;

        if(!target) return;
        
        PnjMotor targetMotor = target.GetComponent<PnjMotor>();
        targetMotor.HandleMoveStatus(false);

        float thirstyPoints = 60f;
        float healthPoints = 80f;
        float strengthPoints = 90f;

        Pnj pnj = target.GetComponent<Pnj>();

        if(pnj.GetEthnicGroup() != Character.Types.Human)
        {
            targetMotor.HandleMoveStatus(true);
            return;
        }

        pnj.SetThirsty(pnj.GetThirsty() - thirstyPoints)
            .SetHealth(pnj.GetHealth() - healthPoints)
            .SetStrength(pnj.GetHealth() - strengthPoints)
        ;
        
        Player player = GameObject.Find("User").GetComponent<Player>();

        player.SetThirsty(player.GetThirsty() + thirstyPoints)
            .SetHealth(player.GetHealth() + healthPoints)
            .SetStrength(player.GetHealth() + strengthPoints)
            .SetExperience(player.GetExperience() + 0.5f)
        ;

        targetMotor.HandleMoveStatus(true);
    }
}
