using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jugador : MonoBehaviour
{
    float health, maxHealth;
    public float dmg;

    public int points;
    public int charSelect;
    public bool isAlive;
    public GameObject mesh, gunMesh, canvasMesh;
    public bool victory;
    public int pickedCharacter;
    public string ShootingKey;
    public GameObject labelPoints;

    public GameObject labelLife;

    // Start is called before the first frame update
    void Start()
    {
        this.Init();
        this.Restart();
    }

    void Init()
    {
        points = 0;

    }

    public void Restart()
    {
        isAlive = true;
        victory = false;

        switch (pickedCharacter)
        {
            case 0: //Pato
                health = 50f;
                dmg = 10f;
                break;
            case 1: //PPotter
                health = 45f;
                dmg = 15f;
                break;
            case 2: //PWizard
                health = 55f;
                dmg = 9f;
                break;
            case 3://PZeus
                health = 60f;
                dmg = 10f;
                break;
            case 4://BatDuck
                health = 54f;
                dmg = 11f;
                break;
            default:
                break;
        }

        maxHealth = health;

        if (labelLife != null)
        {
            string lbllife = "";
            for (int i = 0; i <= health; i++)
            {
                lbllife += "I";
            }
            labelLife.GetComponent<Text>().text = lbllife;
            labelLife.GetComponent<Text>().color = new Color(255, 255, 255);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (labelPoints != null)
        {
            labelPoints.GetComponent<Text>().text = "POINTS: " + points;
        }
    }

    public void takeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }

        if (labelLife != null)
        {
            string lbllife = "";
            for (int i = 0; i <= health; i++)
            {
                lbllife += "I";
            }
            labelLife.GetComponent<Text>().text = lbllife;

            if (health < 40)
                labelLife.GetComponent<Text>().color = new Color(255, 255, 0);

            if (health < 30)
                labelLife.GetComponent<Text>().color = new Color(255, 170, 0);

            if (health < 20)
                labelLife.GetComponent<Text>().color = new Color(255, 0, 0);
        }
    }

    void Die()
    {
        //Destroy(mesh);
        //Destroy(gunMesh);
        //Destroy(canvasMesh);
        isAlive = false;
    }

    public void lost()
    {
        Destroy(mesh);
        Destroy(gunMesh);
        Destroy(canvasMesh);
    }

    public void RestartRound()
    {
        health = maxHealth;
        isAlive = true;
    }
}
