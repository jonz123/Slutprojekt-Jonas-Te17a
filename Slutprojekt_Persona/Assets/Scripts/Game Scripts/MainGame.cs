using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainGame : MonoBehaviour
{

    public Camera P1Camera, P2Camera, P3Camera, P4Camera, BattleCamera;
    public GameObject Character1, Character2, Character3, Character4, Enemy;

    public List<Character> CharacterList = new List<Character> { };

    public Button attackButton;
    public Button skillButton;
    public Button personaButton;
    public Button guardButton;

    public Text turnText;
    public Text hpText;
    public Text spText;

    public int ActionTurn = 0;
    protected int safetyValue = 0;

    public int Enemies = 2; //Hur många fiender som finns i striden

    // Start is called before the first frame update
    void Start()
    {
        Character Player1 = Character1.GetComponent<PlayerCharacter>();
        Character Player2 = Character2.GetComponent<Character>();
        Character Player3 = Character3.GetComponent<Character>();
        Character Player4 = Character4.GetComponent<Character>();
        //Enemy Enemy1 = Enemy.GetComponent<Enemy>();

        CharacterList.Add(Player1);
        CharacterList.Add(Player2);
        CharacterList.Add(Player3);
        CharacterList.Add(Player4);

        attackButton.onClick.AddListener(Attack);
        skillButton.onClick.AddListener(Skills);
        personaButton.onClick.AddListener(Personas);
        guardButton.onClick.AddListener(Guard);

    }

    // Update is called once per frame
    void Update()
    {
        FriendlyTurn();
    }

    void FriendlyTurn() //Byter kamera baserat på vilken runda det är
        //I Persona baseras dena ordning på hur hög agility man har, och det vill jag gärna försöka göra vid ett senare tillfälle.
    {
        if (ActionTurn == 0) //Character 1s runda
        {
            BattleCamera.gameObject.SetActive(false);
            P1Camera.gameObject.SetActive(true);
            hpText.text = string.Format("HP: " + CharacterList[0].hp);
            spText.text = string.Format("HP: " + CharacterList[0].sp);
        }
        if (ActionTurn == 1) //Character 2s runda
        {
            P1Camera.gameObject.SetActive(false);
            P2Camera.gameObject.SetActive(true);
            hpText.text = string.Format("HP: " + CharacterList[1].hp);
            spText.text = string.Format("HP: " + CharacterList[1].sp);
        }
        if (ActionTurn == 2) //Character 3s runda
        {
            P2Camera.gameObject.SetActive(false);
            P3Camera.gameObject.SetActive(true);
            hpText.text = string.Format("HP: " + CharacterList[2].hp);
            spText.text = string.Format("HP: " + CharacterList[2].sp);
        }
        if (ActionTurn == 3) //Character 4s runda
        {
            P3Camera.gameObject.SetActive(false);
            P4Camera.gameObject.SetActive(true);
            hpText.text = string.Format("HP: " + CharacterList[3].hp);
            spText.text = string.Format("HP: " + CharacterList[3].sp);
        }
        if (ActionTurn == 4) //Fiendes runda
        {
            hpText.gameObject.SetActive(false);
            spText.gameObject.SetActive(false);
            P4Camera.gameObject.SetActive(false);
            BattleCamera.gameObject.SetActive(true);
            if (safetyValue < 1)
            {
                quickEnable(2);
                StartCoroutine(waitTwo());
                safetyValue++;
            }
        }
        if (ActionTurn == 5)
        {
            ActionTurn = 0;
        }
    }

    public void Attack()
    {
        //attackButton.interactable = false;
        quickEnable(2);
        turnText.text = string.Format(">" + CharacterList[ActionTurn].charName + " attacks!");
        StartCoroutine(waitTwo());
    }

    public void Skills()
    {

    }

    public void Personas()
    {

    }

    public void Guard()
    {
        CharacterList[ActionTurn].Guard();
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
