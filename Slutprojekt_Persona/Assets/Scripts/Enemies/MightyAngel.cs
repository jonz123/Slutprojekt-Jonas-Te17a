using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MightyAngel : Enemy
{

    // Start is called before the first frame update
    void Start()
    {

        personaName = "Mighty Angel";
        arcana = arcanaList[8];
        level = 25;

        hp = 260;
        sp = 60;

        str = 20;
        mag = 19;
        end = 15;
        agi = 16;
        luk = 12;

        weakness[3] = 1;
        nulls[2] = 1;

    }

    // Update is called once per frame
    void Update()
    {

    }
}
