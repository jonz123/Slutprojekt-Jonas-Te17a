using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mazionga : Skill
{
    // Start is called before the first frame update
    void Start()
    {
        skillName = "Mazionga";
        description = "Deals medium Electric damage to all foes.";
        element[4] = true;
        power = 200;
        target = 5;
        spCost = 16;
        hpCost = 0;
        baseCrit = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
