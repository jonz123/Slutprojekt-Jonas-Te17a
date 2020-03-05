using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillRush : Skill
{
    // Start is called before the first frame update
    void Start()
    {
        skillName = "Kill Rush";
        description = "Deals 1x to 3x light Physical damage to 1 foe.";
        element[1] = 1;
        power = 100;
        target = 1;
        spCost = 0;
        hpCost = 10;
        baseCrit = 10;
        maxRepeats = 3; //skill has a chance to repeat two or three times in a single use
    }

    // Update is called once per frame
    void Update()
    {

    }
}
