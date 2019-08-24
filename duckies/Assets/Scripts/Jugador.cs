using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jugador : MonoBehaviour
{
    float health, maxHealth;
    float dmg;

    public int points;
    public bool isAlive;
    public GameObject mesh, gunMesh, canvasMesh;
    public bool victory;
    public int pickedCharacter;
    public string ShootingKey;
    public GameObject labelPoints;

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
            case 0:
                health = 10;
                dmg = 0;
                break;
            case 1:
                health = 10;
                dmg = 0;
                break;
            case 2:
                health = 10;
                dmg = 0;
                break;
            case 3:
                health = 10;
                dmg = 0;
                break;
            case 4:
                health = 10;
                dmg = 0;
                break;
            case 5:
                health = 10;
                dmg = 0;
                break;
            default:
                break;
        }

        maxHealth = health;

    }

    // Update is called once per frame
    void Update()
    {
        if (labelPoints != null)
        {
            labelPoints.GetComponentInChildren<Text>().text = "Points: " + points;
        }
    }

    public void takeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
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
