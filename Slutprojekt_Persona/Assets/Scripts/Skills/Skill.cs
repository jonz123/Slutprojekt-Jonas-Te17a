﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill : MonoBehaviour
{
    public string skillName; //bet you won't figure out what this one is
    public string description; //description displayed when viewing the skill
    public bool[] element = new bool[8]; //skill element, see exterior note for number equivalent
    public int power; //damage rating OR healing rating (HP restored: user MAG * power) (see Mudoon for how insta-kill works)
    public int target; //1 target or all targets (written as 5 as it is the max amount of enemies)
    public int spCost; //SP cost of using the skill
    public int hpCost; //written in percentage of health to be taken (ie. 14% of 200HP = cost 28HP)
    public int baseCrit; //base chance of a critical hit
    public int hits = 1; //max amount of times a skill can be used in a single turn (default: 1)
    
    public string costString(int hp)
    {
        if (hpCost == 0) //En skill kan inte kosta både HP och SP
        {
            return string.Format(" (" + spCost + "SP)");
        }
        else
        {
            hp = hp / 100;
            int totalHpCost = hp * hpCost;
            return string.Format(" (" + totalHpCost + "HP)");
        }
    }
}
