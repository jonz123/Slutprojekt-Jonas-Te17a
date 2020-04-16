using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainGame : MonoBehaviour
{

    public Camera P1Camera, P2Camera, P3Camera, P4Camera, EnemyCamera;
    public GameObject Character1, Character2, Character3, Character4;

    public List<Character> CharacterList = new List<Character> { };

    public Button attackButton;
    public Button skillButton;
    public Button personaButton;
    public Button guardButton;

    public Text turnText;

    public int ActionTurn = 0;

    public int Enemies = 2; //Hur många fiender som finns i striden

    // Start is called before the first frame update
    void Start()
    {
        GameObject Character1 = GameObject.Find("MC");
        Character Player1 = Character1.GetComponent<PlayerCharacter>();
        GameObject Character2 = GameObject.Find("Char2");
        Character Player2 = Character1.GetComponent<Character>();
        GameObject Character3 = GameObject.Find("Char3");
        Character Player3 = Character1.GetComponent<Character>();
        GameObject Character4 = GameObject.Find("Char4");
        Character Player4 = Character1.GetComponent<Character>();

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
    {
        if (ActionTurn == 0)
        {
            EnemyCamera.gameObject.SetActive(false);
            P1Camera.gameObject.SetActive(true);
        }
        if (ActionTurn == 1)
        {
            P1Camera.gameObject.SetActive(false);
            P2Camera.gameObject.SetActive(true);
        }
        if (ActionTurn == 2)
        {
            P2Camera.gameObject.SetActive(false);
            P3Camera.gameObject.SetActive(true);
        }
        if (ActionTurn == 3)
        {
            P3Camera.gameObject.SetActive(false);
            P4Camera.gameObject.SetActive(true);
        }
        /*if (ActionTurn == 4)
        {
            P4Camera.gameObject.SetActive(false);
            EnemyCamera.gameObject.SetActive(true);
        }*/
        if (ActionTurn == 4)
        {
            ActionTurn = 0;
        }
    }

    public void Attack()
    {
        //attackButton.interactable = false;
        turnText.text = CharacterList[ActionTurn].name + " attacks!";
        ActionTurn++;
    }

    public void Skills()
    {

    }

    public void Personas()
    {

    }

    public void Guard()
    {

    }

}
