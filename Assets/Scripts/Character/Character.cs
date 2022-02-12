using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Global character
public class Character : MonoBehaviour
{
    [SerializeField]
    protected int id;

    [SerializeField]
    protected Types ethnicGroup;

    [SerializeField]
    protected string username;
    
    [SerializeField]
    protected string lastname;
    
    [SerializeField]
    protected string age;

    [SerializeField]
    protected float healthPoint = 100f;

    [SerializeField]
    protected float strengthPoint = 100f;

    [SerializeField]
    protected float thirstyPoint = 100f;

    [SerializeField]
    protected float experience = 0f;

    public enum Types {
        Human,
        Vampyr
    }

    public Character SetHealth(float _healthPoint)
    {
        healthPoint = _healthPoint;

        if(healthPoint <= 0)
        {
            healthPoint = 0;
        }

        if(healthPoint >= 100)
        {
            healthPoint = 100;
        }

        return this;
    }
    
    public float GetHealth()
    {
        return healthPoint;
    }

    public float GetStrength()
    {
        return strengthPoint;
    }

    public Character SetStrength(float _strengthPoint)
    {
        strengthPoint = _strengthPoint;

        if(strengthPoint <= 0)
        {
            strengthPoint = 0;
        }

        if(strengthPoint >= 100)
        {
            strengthPoint = 100;
        }

        return this;
    }

    public float GetThirsty()
    {
        return thirstyPoint;
    }

    public Character SetThirsty(float _thirstyPoint)
    {
        thirstyPoint = _thirstyPoint;
        
        if(thirstyPoint <= 0)
        {
            thirstyPoint = 0;
        }

        if(thirstyPoint >= 100)
        {
            thirstyPoint = 100;
        }

        return this;
    }

    public float GetExperience()
    {
        return experience;
    }

    public Character SetExperience(float _experience)
    {
        experience = _experience;
        
        if(experience <= 0)
        {
            throw new System.Exception("Experience must be positive value");
        }

        return this;
    }

    public Types GetEthnicGroup()
    {
        return ethnicGroup;
    }
}
