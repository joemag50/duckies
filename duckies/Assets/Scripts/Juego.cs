using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Juego : MonoBehaviour
{
    static public float floatingPoint = 2f;
    static public float jumpingForce = 7f;
    static public float speed = 30f;
    static public float speedG = 5f;

    public GameObject Prefab;
    public Transform pos1, pos2;
    public GameObject waterPlane;

    GameObject player1, player2;
    bool roundEnded;
    bool gameEnded;

    // Use this for initialization
    void Awake()
    {
        waterPlane = Instantiate(waterPlane, new Vector3(0f, -95f, 0f), Quaternion.identity);
    }

    void Start()
    {
        player1 = Instantiate(Prefab, pos1.position, Quaternion.identity);
        player1.GetComponent<mov>().horizontal="Horizontal";
        player1.GetComponent<mov>().vertical = "Vertical";
        player1.GetComponent<Float>().WaterLevel = waterPlane;
        player1.GetComponentInChildren<Camera>().rect = new Rect(0.5f, 0f, 1f, 1f);


        player2 = Instantiate(Prefab, pos2.position, Quaternion.identity);
        player2.GetComponent<mov>().horizontal="Horizontal2";
        player2.GetComponent<mov>().vertical="Vertical2";
        player2.GetComponent<Float>().WaterLevel = waterPlane;
        player2.GetComponentInChildren<Camera>().rect = new Rect(-0.5f, 0f, 1f, 1f);

        roundEnded = false;
        gameEnded = false;
    }

    // Update is called once per frame
    void Update()
    {
        if ((!player1.GetComponent<Jugador>().isAlive || !player2.GetComponent<Jugador>().isAlive) && !roundEnded)
        {
            Debug.Log("Ded");

            if (player1.GetComponent<Jugador>().isAlive)
            {
                player1.GetComponent<Jugador>().points++;
            }
            else if (player2.GetComponent<Jugador>().isAlive)
            {
                player2.GetComponent<Jugador>().points++;
            }

            roundEnded = true;
            this.CheckVictory();
        }
    }

    void CheckVictory()
    {
        if (!gameEnded)
        {
            if (player1.GetComponent<Jugador>().points >= 3 || player2.GetComponent<Jugador>().points >= 3)
            {
                if (player1.GetComponent<Jugador>().points >= 3)
                {
                    player1.GetComponent<Jugador>().victory = true;
                    player2.GetComponent<Jugador>().victory = false;
                }
                else if (player2.GetComponent<Jugador>().points >= 3)
                {
                    player1.GetComponent<Jugador>().victory = false;
                    player2.GetComponent<Jugador>().victory = true;
                }
                gameEnded = true;

            }
        }
    }
}
