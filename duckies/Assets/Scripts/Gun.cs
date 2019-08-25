using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    private AudioSource mAudio;
    float damage;
    float range = 300f;
    Jugador selfPlayer;

    void Start()
    {
        selfPlayer = GetComponentInParent<Jugador>();
        mAudio = GetComponent<AudioSource>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(selfPlayer.ShootingKey))
        {
            mAudio.Play(); 
            Shoot();
        }
    }

    void Shoot()
    {

        RaycastHit hit;
        Debug.Log("shoot: " + selfPlayer.ShootingKey);
        if (Physics.Raycast(transform.position, transform.right, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Jugador jugador = hit.transform.GetComponent<Jugador>();
            if (jugador != null)
            {
                jugador.takeDamage(selfPlayer.dmg);
            }
        }
    }
}