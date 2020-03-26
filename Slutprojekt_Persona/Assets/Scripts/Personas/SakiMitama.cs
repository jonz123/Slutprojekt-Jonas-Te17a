using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SakiMitama : Persona
{
    // Start is called before the first frame update
    void Start()
    {
        personaName = "Saki Mitama";
        arcana = arcanaList[2];
        level = 11;
        experience = 0;
        str = 5;
        mag = 12;
        end = 5;
        agi = 8;
        luk = 10;

        weakness[5] = true;
        resists[3] = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
