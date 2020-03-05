using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieryTrickster : Enemy
{
    // Start is called before the first frame update
    void Start()
    {

        personaName = "Fiery Trickster";
        arcana = arcanaList[8];
        level = 25;

        hp = 85;
        sp = 45;

        str = 7;
        mag = 14;
        end = 9;
        agi = 8;
        luk = 11;

        weakness[3] = 1;
        nulls[2] = 1;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
