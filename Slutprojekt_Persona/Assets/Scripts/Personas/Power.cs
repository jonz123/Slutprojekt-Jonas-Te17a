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

        weakness[7] = 1;
        resists[5] = 1;
        nulls[6] = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
