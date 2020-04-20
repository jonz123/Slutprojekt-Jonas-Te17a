using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : Character
{

    [SerializeField]
    public Persona loadLevelPersona;//Huvudkaraktären kan ha flera personas, men ska följa Mirainokos huvudlevel

    void Start()
    {
        charName = "Player";
        loadLevelPersona = persona.GetComponent<Mirainoko>();
        loadPersona = persona.GetComponent<Mirainoko>(); //(*1, see below)
        level = loadLevelPersona.level;
        hp = 220;
        sp = 95;
        weaponDamage = 80;
    }

    void Update()
    {
        
    }
}

/*When the player changes Persona, they reach for a script inside a common object known as WildCard_Persona. This is to simplify things for now, but if each Persona is going
 to have altering appearances, it would be better to make each one a new game object. As such, instead of looking for a script (*1), it would look for a game object with
 that particular script. Unless an object can change mesh, animation and all that based on what script is called, but I have no experience with that.*/

//this was easier to put in english than swedish lol