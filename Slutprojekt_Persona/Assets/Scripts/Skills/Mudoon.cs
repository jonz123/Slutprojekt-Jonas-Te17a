using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mudoon : Skill
{
    // Start is called before the first frame update
    void Start()
    {
        skillName = "Mudoon";
        description = "Darkness: high chance of instant kill, 1 foe.";
        element[7] = true;
        power = 60; //60% chance of insta-kill without weakness/resist (weakness makes it 80%, resist makes it 40%)
        target = 1;
        spCost = 15;
        hpCost = 0;
        baseCrit = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
