using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Director : MonoBehaviour
{
    public float wallet;
    public MobCard[] monsters;
    public float creditMultiplier;

    private int testint = 0;
    public virtual void Awake()
    {
        
    }

    public virtual void Init()
    {
        
    }

    //This needs to be where the MobCards are sorted into possible Spawns based on The coEf
    protected void LoadMonsters()
    {
        monsters = Resources.LoadAll<MobCard>("Mobs");
        Array.Sort(monsters,
            delegate(MobCard x, MobCard y) { return x.creditCost.CompareTo(y.creditCost); });
    }

   
    
}
