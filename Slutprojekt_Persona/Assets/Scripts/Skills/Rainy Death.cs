using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainyDeath : Skill
{
    // Start is called before the first frame update
    void Start()
    {
        skillName = "Rainy Death";
        description = "Deals heavy Physical damage to 1 foe.";
        element[1] = true;
        power = 350;
        target = 1;
        spCost = 0;
        hpCost = 20;
        baseCrit = 35;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
