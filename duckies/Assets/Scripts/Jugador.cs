using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public float health;
    public int points;
    public bool isAlive;
    public GameObject mesh;
    public bool victory;

    // Start is called before the first frame update
    void Start()
    {
        this.Restart();
    }

    public void Restart()
    {
        points = 0;
        isAlive = true;
        victory = false;
    }

    // Update is called once per frame
    void Update()
    {
        health -= 0.1f;

        if (health < 1f && isAlive) {
            Die();
        }
    }

    void Die()
    {
        Destroy(mesh);
        isAlive = false;
    }
}
