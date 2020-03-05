using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Azrael : Persona
{
    // Start is called before the first frame update
    void Start()
    {
        personaName = "Azrael";
        arcana = arcanaList[13];
        level = 26;
        experience = 0;
        str = 29;
        mag = 20;
        end = 14;
        agi = 19;
        luk = 12;

        weakness[6] = 1;
        resists[1] = 1;
        nulls[6] = 1;

        Skill mudoon = new Mudoon();
        Skill rainydeath = new RainyDeath();
        Skill eiga = new Eiga();

        skillList.Add(mudoon);
        skillList.Add(rainydeath);
        skillList.Add(eiga);

    }

    // Update is called once per frame
    void Update()
    {

    }

}
