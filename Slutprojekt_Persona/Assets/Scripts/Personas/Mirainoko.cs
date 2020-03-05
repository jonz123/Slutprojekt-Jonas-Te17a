using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Mirainoko : Persona
{
    // Start is called before the first frame update
    void Start()
    {
        name = "Mirainoko";
        arcana = arcanaList[0];
        level = 25;
        experience = 0;
        str = 25;
        mag = 19;
        end = 15;
        agi = 16;
        luk = 12;

        weakness[7] = 1;
        resists[6] = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
