using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eiga : Skill
{
    // Start is called before the first frame update
    void Start()
    {
        skillName = "Eiga";
        description = "Deals medium Dark damage to 1 foe.";
        element[7] = 1;
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
