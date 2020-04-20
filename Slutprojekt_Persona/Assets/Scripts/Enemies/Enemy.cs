using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Persona
{

    public int hp;
    public int sp;

    public void TakeDamage(int damageTaken)
    {
        hp = hp - damageTaken;
    }
}
