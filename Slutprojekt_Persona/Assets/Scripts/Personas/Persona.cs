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

        protected int nextXP = level * 200; //används i LevelUp()

        public int[] weakness = new int[8];
        public int[] resists = new int[8];
        public int[] nulls = new int[8];

        public List<Skill> skillList = new List<Skill>();

        public List<string> arcanaList = new List<string>() { "Fool", "Magician", "Priestess", "Empress", "Emperor", "Hierophant", "Lovers", "Chariot", "Justice", "Hermit", "Fortune", "Strength", "Hanged Man", "Death", "Temperance", "Devil", "Tower", "Star", "Moon", "Sun", "Judgement", "World" };
        
        public void LevelUp()
        {
        level++;

        Random gen = new Random();

        int random = gen.Next(0, 5);

        //randomly increase en stat (GÖR TILL SEPARAT METOD SÅ ATT DET KAN GÖRAS 1-3 GGR)
        //det nedstående hade varit lättare om alla stats fanns i en array, men det hade varit svårare att hålla koll på
        if (random = 0)
        {
            random = gen.Next(1, 2);
            str = str + random;
        }
        if (random = 1)
        {
            random = gen.Next(1, 2);
            mag = mag + random;
        }
        if (random = 2)
        {
            random = gen.Next(1, 2);
            end = end + random;
        }
        if (random = 3)
        {
            random = gen.Next(1, 2);
            agi = agi + random;
        }
        if (random = 4)
        {
            random = gen.Next(1, 2);
            luk = luk + random;
        }

        nextXP = level * 200;
        nextXP = nextXP + 300;
        }
        
}