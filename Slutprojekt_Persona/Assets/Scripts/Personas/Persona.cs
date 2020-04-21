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

        public List<string> arcanaList = new List<string>() { "Fool", "Magician", "Priestess", "Empress", "Emperor", "Hierophant", "Lovers", "Chariot",
            "Justice", "Hermit", "Fortune", "Strength", "Hanged Man", "Death", "Temperance", "Devil", "Tower", "Star", "Moon", "Sun", "Judgement", "World" };

        public int DealDamage(int eDef, int Hits, int ATK, int element) //eDef hämtar fiendens defense som är baserad på dess END. Hits hämtar antalet hits som en attack utgör. ATK är vapen.
        {
            float enemyDefense = eDef; //Konverterar integers till floats för att matten ska fungera
            float attackerStr = str;
            
            float strDamage = Mathf.Sqrt(attackerStr / enemyDefense * ATK) * 5;
            strDamage = strDamage * Random.Range(0.95f, 1.05f);
            int totalDamage = Mathf.RoundToInt(strDamage);

            return totalDamage * Hits;
        }

        public bool Miss(int enemyAGI) //Standard är det 90% att träffa, men om motståndaren är snabbare så sjunker det till 70%
        {
            int favoredChance;
            if (enemyAGI > agi)
            {
                favoredChance = 3;
            }
            else
            {
                favoredChance = 1;
            }

            System.Random rand = new System.Random();
            int chance = rand.Next(1, 10);
            if (chance > favoredChance)
            {
                return false; //Attacken träffar
            }
            else
            {
                return true; //Attacken missar
            }
        }

        bool Weak(int atkElement)
        {
            if (weakness[atkElement] == true)
            {
                return true;
        }
            else
            {
                return false;
            }
            
        }

}

/*

Damage formula from Persona 5:

DMG = 5 x sqrt(ST/EN x ATK) x MOD x HITS X RND

DMG = Damage
ST = Character's Strength stat
EN = Enemy's Endurance stat
ATK = Atk value of equipped weapon OR Pwr value of used skill
MOD = Modifier based on the difference between character level and enemy level
HITS= Number of hits (for physical skills)
RND = Randomness factor (according to DragoonKain33, may be roughly between 0.95 and 1.05)

I will be simplyfying it by using the following:
DMG = 5 x sqrt(ST/EN x ATK) x HITS x RND

Simplification is needed due to the modifier value being unclear as to what it means.

*/

//================================================================================================================\\

/* dont mind this
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
*/
