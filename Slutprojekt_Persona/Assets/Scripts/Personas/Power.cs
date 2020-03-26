using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : Persona
{
    // Start is called before the first frame update
    void Start()
    {
        personaName = "Power";
        arcana = arcanaList[8];
        level = 25;
        experience = 0;
        str = 20;
        mag = 19;
        end = 15;
        agi = 16;
        luk = 12;

        weakness[7] = true;
        resists[5] = true;
        nulls[6] = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
