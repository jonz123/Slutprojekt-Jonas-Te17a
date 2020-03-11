using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField]
    public GameObject persona;
    protected Persona loadPersona; //osynlig för att den enbart används för att hämta level, onödig att ha den i Unitys interface

    public string name; //jag vet inte vad den här gör
    public int level; //ska baseras utifrån karaktärens personas level
    public int hp; //health points
    public int sp; //spirit points
}
