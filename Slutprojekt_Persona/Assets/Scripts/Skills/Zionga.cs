using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zionga : Skill
{
    // Start is called before the first frame update
    void Start()
    {
        skillName = "Zionga";
        description = "Deals medium Electric damage to 1 foe.";
        element[4] = 1;
        power = 200;
        target = 1;
        spCost = 8;
        hpCost = 0;
        baseCrit = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
