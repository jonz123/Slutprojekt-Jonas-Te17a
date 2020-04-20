using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField]
    public GameObject persona;
    public Persona loadPersona; //vill att den ska vara osynlig för att den enbart används för att hämta stats, onödig att ha den i Unitys interface

    public string charName; //jag vet inte vad den här gör
    public int level; //ska baseras utifrån karaktärens personas level
    public int hp; //health points
    public int sp; //spirit points

    public int weaponDamage;

    bool isGuarding;

    void Start()
    {
        loadPersona = persona.GetComponent<Persona>();
        level = loadPersona.level;
        weaponDamage = 80;
    }

    void takeDamage(int damageTaken)
    {
        if (isGuarding == true)
        {
            isGuarding = false;
            hp = hp - damageTaken / 2;
        }
        else
        {
            hp = hp - damageTaken;
        }
        
    }

    public void Guard()
    {
        isGuarding = true;
    }
}


