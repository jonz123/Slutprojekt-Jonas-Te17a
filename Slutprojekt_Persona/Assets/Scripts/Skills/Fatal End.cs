using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FatalEnd : Skill
{
    // Start is called before the first frame update
    void Start()
    {
        skillName = "Fatal End";
        description = "Deals medium Physical damage to 1 foe.";
        element[1] = 1;
        power = 250;
        target = 1;
        spCost = 0;
        hpCost = 14;
        baseCrit = 20;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
