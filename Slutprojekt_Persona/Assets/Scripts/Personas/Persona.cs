using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Persona : MonoBehaviour
{
        public string name;
        public string arcana;
        public int level;
        public int experience;
        public int str;
        public int mag;
        public int end;
        public int agi;
        public int luk;

        public int[] weakness = new int[7];
        public int[] resists = new int[7];
        public int[] nulls = new int[7];

        public List<string> arcanaList = new List<string>() { "Fool", "Magician", "Priestess", "Empress", "Emperor", "Hierophant", "Lovers", "Chariot", "Justice", "Hermit", "Fortune", "Strength", "Hanged Man", "Death", "Temperance", "Devil", "Tower", "Star", "Moon", "Sun", "Judgement", "World" };

}

