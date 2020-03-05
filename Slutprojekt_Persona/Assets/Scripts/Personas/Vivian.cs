using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Vivian : Persona
{
    // Start is called before the first frame update
    void Start()
    {
        personaName = "Vivian";
        arcana = arcanaList[6];
        level = 23;
        experience = 0;
        str = 10;
        mag = 21;
        end = 10;
        agi = 19;
        luk = 13;

        weakness[7] = 1;
        resists[3] = 1;
        nulls[6] = 1;

        Skill diarama = new Diarama();
        Skill media = new Media();

        skillList.Add(diarama);
        skillList.Add(media);

    }

    // Update is called once per frame
    void Update()
    {

    }

}
