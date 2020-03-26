using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Persona : MonoBehaviour
{
        public string personaName;
        public string arcana;
        public int level;
        public int experience;
        public int str;
        public int mag;
        public int end;
        public int agi;
        public int luk;

        protected int nextXP; //används i LevelUp(), det gick inte att definera dess värde här eftersom att level är obestämd

        public bool[] weakness = new bool[8];
        public bool[] resists = new bool[8];
        public bool[] nulls = new bool[8];

        public List<Skill> skillList = new List<Skill>();

        public List<string> arcanaList = new List<string>() { "Fool", "Magician", "Priestess", "Empress", "Emperor", "Hierophant", "Lovers", "Chariot", "Justice", "Hermit", "Fortune", "Strength", "Hanged Man", "Death", "Temperance", "Devil", "Tower", "Star", "Moon", "Sun", "Judgement", "World" };
        
        public void LevelUp()
        {
        level++;

        System.Random gen = new System.Random();

        int random = gen.Next(0, 1); //chans att få ökning i tre stats istället för två

        if (random == 0)
        {
            increaseStat();
            increaseStat();
        }
        if (random == 1)
        {
            increaseStat();
            increaseStat();
            increaseStat();
        }
        

        nextXP = level * 200;
        nextXP = nextXP + 300;
        }

        void increaseStat()
        {
        System.Random gen = new System.Random();

        int random = gen.Next(0, 5);

        //randomly increase på en stat
        //det nedstående hade varit lättare om alla stats fanns i en array, men det hade varit svårare att hålla koll på
        if (random == 0)
            {
                random = gen.Next(1, 2);
                str = str + random;
            }
        if (random == 1)
            {
                random = gen.Next(1, 2);
                mag = mag + random;
            }
        if (random == 2)
            {
                random = gen.Next(1, 2);
                end = end + random;
            }
        if (random == 3)
            {
                random = gen.Next(1, 2);
                agi = agi + random;
            }
        if (random == 4)
            {
                random = gen.Next(1, 2);
                luk = luk + random;
            }
        }
        
}