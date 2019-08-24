using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    float damage = 10f;
    float range = 100f;
    Jugador selfPlayer;

    void Start()
    {
        selfPlayer = GetComponentInParent<Jugador>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(selfPlayer.ShootingKey))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        Debug.Log("shoot: " + selfPlayer.ShootingKey);
        if (Physics.Raycast(transform.position, transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Jugador jugador = hit.transform.GetComponent<Jugador>();
            if (jugador != null)
            {
                jugador.takeDamage(damage);
            }
        }
    }
}