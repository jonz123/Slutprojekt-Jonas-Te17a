using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainGame : MonoBehaviour
{

    public Camera P1Camera, P2Camera, P3Camera, P4Camera, BattleCamera;
    public GameObject Character1, Character2, Character3, Character4, EnemyBattler;

    public List<Character> CharacterList = new List<Character> { };
    public List<Enemy> EnemyList = new List<Enemy> { };
    public List<GameObject> PositionList = new List<GameObject> { };

    public Button attackButton, skillButton, personaButton, guardButton;

    public GameObject skillButtons;
    public Button skill1, skill2, skill3, cancel;
    public Text s1Text, s2Text, s3Text, skillDesc;

    public Text turnText, hpText, spText, enemyHPText;

    public int ActionTurn = 0;
    protected int safetyValue = 0;

    public GameObject dataHandlerOBJ;
    Ownership dataHandler;

    static System.Random random = new System.Random();

    // Start is called before the first frame update
    void Start()
    {

        Character Player1 = Character1.GetComponent<Character>();
        Character Player2 = Character2.GetComponent<Character>();
        Character Player3 = Character3.GetComponent<Character>();
        Character Player4 = Character4.GetComponent<Character>();
        Enemy Enemy1 = EnemyBattler.GetComponent<Enemy>();

        //Jag vet inget mer effektivt sätt att samla allt i en Public lista än det här
        CharacterList.Add(Player1);
        CharacterList.Add(Player2);
        CharacterList.Add(Player3);
        CharacterList.Add(Player4);

        EnemyList.Add(Enemy1);

        PositionList.Add(Character1);
        PositionList.Add(Character2);
        PositionList.Add(Character3);
        PositionList.Add(Character4);

        attackButton.onClick.AddListener(Attack);
        skillButton.onClick.AddListener(Skills);
        personaButton.onClick.AddListener(Personas);
        guardButton.onClick.AddListener(Guard);

        cancel.onClick.AddListener(Cancel);

        dataHandler = dataHandlerOBJ.GetComponent<Ownership>();

    }

    // Update is called once per frame
    void Update()
    {
        
        FriendlyTurn();
        
    }

    void FriendlyTurn() //Byter kamera baserat på vilken runda det är, gjordes som en metod ifall jag vill göra annat i Update
        //I Persona baseras dena ordning på hur hög agility man har, och det vill jag gärna försöka göra vid ett senare tillfälle.
    {
        if (ActionTurn == 0) //Character 1s runda
        {
            BattleCamera.gameObject.SetActive(false);
            P1Camera.gameObject.SetActive(true);
            hpText.text = string.Format("HP: " + CharacterList[0].hp);
            spText.text = string.Format("SP: " + CharacterList[0].sp);
        }
        if (ActionTurn == 1) //Character 2s runda
        {
            P1Camera.gameObject.SetActive(false);
            P2Camera.gameObject.SetActive(true);
            hpText.text = string.Format("HP: " + CharacterList[1].hp);
            spText.text = string.Format("SP: " + CharacterList[1].sp);
        }
        if (ActionTurn == 2) //Character 3s runda
        {
            P2Camera.gameObject.SetActive(false);
            P3Camera.gameObject.SetActive(true);
            hpText.text = string.Format("HP: " + CharacterList[2].hp);
            spText.text = string.Format("SP: " + CharacterList[2].sp);
        }
        if (ActionTurn == 3) //Character 4s runda
        {
            P3Camera.gameObject.SetActive(false);
            P4Camera.gameObject.SetActive(true);
            hpText.text = string.Format("HP: " + CharacterList[3].hp);
            spText.text = string.Format("SP: " + CharacterList[3].sp);
        }
        if (ActionTurn == 4) //Fiendes runda
        {
            hpText.gameObject.SetActive(false);
            spText.gameObject.SetActive(false);
            enemyHPText.gameObject.SetActive(false);
            P4Camera.gameObject.SetActive(false);
            BattleCamera.gameObject.SetActive(true);
            if (safetyValue < 1)
            {
                quickEnable(2);
                EnemyTurn();
                StartCoroutine(waitTwo());
                safetyValue++;
            }
        }
        if (ActionTurn == 5)
        {
            ActionTurn = 0;
        }
        enemyHPText.text = string.Format("ENEMY HP: " + EnemyList[0].hp);

        if (EnemyList[0].hp < 1) //När fienden dör så avslutas spelet (för tillfället)
        {
            print("you are winner");
            Application.Quit();
        }
    }

    void EnemyTurn()
    {
        if (EnemyList[0].hp < 100) //Om HP < 100 ska det finnas en chans för fienden att be om nåd, vilket get spelaren chansen att få Persona:n gratis
        {
            //turnText.text = string.Format(">" + EnemyList[0].name + " begs for mercy!\n>What will you do?");
        }
    }

    public void Attack()
    {
        quickEnable(2);
        if (EnemyList[0].Miss(EnemyList[0].agi) == false)
        {
            int dealtDamage = CharacterList[ActionTurn].loadPersona.DealDamage(EnemyList[0].end, 1, CharacterList[ActionTurn].weaponDamage, 1);
            EnemyList[0].TakeDamage(dealtDamage); //EnemyList[0] kan ersättas med EnemyList[vald fiende] om spelaren får välja vilken fiende den vill slå
            turnText.text = string.Format(">" + CharacterList[ActionTurn].charName + " attacks!\n>Dealt " + dealtDamage + " damage!");
        }
        else
        {
            turnText.text = string.Format(">" + CharacterList[ActionTurn].charName + " attacks!\n>Attack missed!");
        }
        //Koden över kallar metoden som skadar fienden med hjälp av DealDamage-valuen som finns i karaktärerna.
        StartCoroutine(waitTwo());
    }

    public void Skills() //När knappen Skills trycks så öppnas en meny där skills kan väljas
    {
        quickEnable(2);
        skillButtons.gameObject.SetActive(true);

        print(CharacterList[ActionTurn].loadPersona.skillList[0].costString(CharacterList[ActionTurn].hp));

        //Dessa defineras för att göra koden ett snäpp mindre krånglig, som om den inte var krånglig nog
        string s1 = CharacterList[ActionTurn].loadPersona.skillList[0].skillName; 
        string s2 = CharacterList[ActionTurn].loadPersona.skillList[1].skillName;

        string s1d = CharacterList[ActionTurn].loadPersona.skillList[0].description;
        string s2d = CharacterList[ActionTurn].loadPersona.skillList[1].description;

        string s1c = CharacterList[ActionTurn].loadPersona.skillList[0].costString(CharacterList[ActionTurn].hp);
        string s2c = CharacterList[ActionTurn].loadPersona.skillList[1].costString(CharacterList[ActionTurn].hp);

        s1Text.text = s1;
        s2Text.text = s2;

        if (CharacterList[ActionTurn].loadPersona.skillList.Count == 3)
        {
            skill3.gameObject.SetActive(true);
            string s3 = CharacterList[ActionTurn].loadPersona.skillList[2].skillName;
            string s3d = CharacterList[ActionTurn].loadPersona.skillList[2].description;
            string s3c = CharacterList[ActionTurn].loadPersona.skillList[2].costString(CharacterList[ActionTurn].hp);
            s3Text.text = s3;
            skillDesc.text = string.Format(s1 + s1c + "\n" + s1d + "\n\n" + s2 + s2c + "\n" + s2d + "\n\n" + s3 + s3c + "\n" + s3d);
        }
        else
        {
            skillDesc.text = string.Format(s1 + s1c + "\n" + s1d + "\n\n" + s2 + s2c + "\n" + s2d);
            skill3.gameObject.SetActive(false);
        }

        //Min kunskap om Text är inte jätteavancerad, men det är inte riktigt likt console.writeline så console.write fungerar inte riktigt. Hade isåfall kunnat lägga till en linje per antal skills
        //Det ultimata skulle såklart vara att ändra description baserat på vilken skill som musen hänger över

        //Nedan råder samma skript som Attack, men med inflytande av skills. Jag hade kunnat använda Attacks kod, men det gick inte att kalla fram variabler när man trycker på knappen Attack.
        /*
        quickEnable(2);
        if (EnemyList[0].Miss(EnemyList[0].agi) == false)
        {
            int dealtDamage = CharacterList[ActionTurn].loadPersona.DealDamage(EnemyList[0].end, 1, CharacterList[ActionTurn].weaponDamage, 1);
            EnemyList[0].TakeDamage(dealtDamage); //EnemyList[0] kan ersättas med EnemyList[vald fiende] om spelaren får välja vilken fiende den vill slå
            turnText.text = string.Format(">" + CharacterList[ActionTurn].charName + " attacks!\n>Dealt " + dealtDamage + " damage!");
        }
        else
        {
            turnText.text = string.Format(">" + CharacterList[ActionTurn].charName + " attacks!\n>Attack missed!");
        }
        
        //Koden över kallar metoden som skadar fienden med hjälp av DealDamage-valuen som finns i karaktärerna.
        StartCoroutine(waitTwo());*/

    }

    public void Personas()
    {

    }

    public void Guard()
    {
        CharacterList[ActionTurn].Guard();
    }

    public void Cancel()
    {
        quickEnable(1);
        skillButtons.gameObject.SetActive(false);
    }

    IEnumerator waitTwo()
    {
        yield return new WaitForSeconds(2);
        quickEnable(1);
        if (ActionTurn == 4)
        {
            personaButton.gameObject.SetActive(true);
            hpText.gameObject.SetActive(true);
            spText.gameObject.SetActive(true);
            enemyHPText.gameObject.SetActive(true);
            safetyValue = 0;
        }
        ActionTurn++;
    }

    void quickEnable(int i) //för att slippa disable/enable överallt i koden
    {
        if (i == 1) //Huvudkaraktärens runda
        {
            attackButton.gameObject.SetActive(true);
            skillButton.gameObject.SetActive(true);
            guardButton.gameObject.SetActive(true);
            if (ActionTurn == 0)
            {
                personaButton.gameObject.SetActive(true);
            }
            print("enabled");
        }
        if (i == 2) //Attack eller fiendes runda
        {
            attackButton.gameObject.SetActive(false);
            skillButton.gameObject.SetActive(false);
            personaButton.gameObject.SetActive(false);
            guardButton.gameObject.SetActive(false);
            print("disabled");
        }
        
    }
}
