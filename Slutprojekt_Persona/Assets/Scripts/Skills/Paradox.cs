using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paradox : Skill
{
    // Start is called before the first frame update
    void Start()
    {
        skillName = "Paradox";
        description = "Deals medium Almighty damage to 1 foe.";
        element[0] = true; //almighty
        power = 240;
        target = 1;
        spCost = 10;
        hpCost = 0;
        baseCrit = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
