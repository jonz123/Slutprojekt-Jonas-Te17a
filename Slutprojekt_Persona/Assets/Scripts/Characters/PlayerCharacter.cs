using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : Character
{

    [SerializeField]
    GameObject InitialPersona; //Huvudkaraktären kan ha flera personas, men ska följa Mirainokos huvudlevel

    void Start()
    {
        name = "Player";
        loadPersona = InitialPersona.GetComponent<Mirainoko>();
        level = loadPersona.level;
        hp = 220;
        sp = 95;
    }

    void Update()
    {
        
    }
}
