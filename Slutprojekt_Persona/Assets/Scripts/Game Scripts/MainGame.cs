using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainGame : MonoBehaviour
{

    public Camera activeCamera;
    public GameObject activeCharacter;
    int cameraID;

    public Button attackButton;
    public Button skillButton;
    public Button personaButton;
    public Button guardButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        attackButton.onClick.AddListener(Attack);
        skillButton.onClick.AddListener(Skills);
        personaButton.onClick.AddListener(Personas);
        guardButton.onClick.AddListener(Guard);
    }

    void FriendlyTurn()
    {

    }

    void Attack()
    {

    }

    void Skills()
    {

    }

    void Personas()
    {

    }

    void Guard()
    {

    }
}
