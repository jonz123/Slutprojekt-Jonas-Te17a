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

        weakness[7] = true;
        resists[3] = true;
        nulls[6] = true;

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
