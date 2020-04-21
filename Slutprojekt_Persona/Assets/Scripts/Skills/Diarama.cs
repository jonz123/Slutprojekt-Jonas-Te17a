using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diarama : Skill
{
    // Start is called before the first frame update
    void Start()
    {
        skillName = "Diarama";
        description = "Moderately restores 1 ally's HP.";
        element[0] = true;
        power = 6; //user's MAG * power = HP restored (MAG 22 * 6 = 132HP)
        target = 1;
        spCost = 6;
        hpCost = 0;
        baseCrit = 0;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
