using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Media : Skill
{
    // Start is called before the first frame update
    void Start()
    {
        skillName = "Media";
        description = "Slightly restores party's HP.";
        element[0] = 1;
        power = 3; //user's MAG * power = HP restored (MAG 22 * 3 = 66HP)
        target = 5;
        spCost = 7;
        hpCost = 0;
        baseCrit = 0;

    }

    // Update is called once per frame
    void Update()
    {

    }
}
