using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Enkidu : Persona
{
    // Start is called before the first frame update
    void Start()
    {
        personaName = "Enkidu";
        arcana = arcanaList[17];
        level = 24;
        experience = 0;
        str = 18;
        mag = 21;
        end = 17;
        agi = 19;
        luk = 20;

        weakness[7] = true;
        weakness[5] = true;
        resists[2] = true;

        Skill zionga = gameObject.AddComponent<Zionga>();
        Skill mazionga = gameObject.AddComponent<Mazionga>();
        Skill killrush = gameObject.AddComponent<KillRush>();

        skillList.Add(zionga);
        skillList.Add(mazionga);
        skillList.Add(killrush);

    }

    // Update is called once per frame
    void Update()
    {

    }

}
