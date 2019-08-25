using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject gunprefab;
    private AudioSource mAudio;
    float damage;
    float range = 300f;
    Jugador selfPlayer;

    float coolDownTime = 2;
    float initTime = 2;

    void Start()
    {
        selfPlayer = GetComponentInParent<Jugador>();
        mAudio = GetComponent<AudioSource>(); 
    }

    // Update is called once per frame
    void Update()
    {
        coolDownTime -= Time.deltaTime;

        if (Input.GetKey(selfPlayer.ShootingKey) && coolDownTime < 0)
        {
            mAudio.Play(); 
            Shoot();
            coolDownTime = initTime;
        }
    }

    void Shoot()
    {
        if (Juego.paused)
            return;

        GameObject o = Instantiate(gunprefab, transform.position, transform.rotation);
        o.GetComponent<Rigidbody>().velocity = transform.TransformDirection(Vector3.right * 500);
        o.GetComponent<DeleteMe>().owner = GetComponentInParent<Jugador>().gameObject.name;

        /*
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.right, out hit, range))
        {
            Jugador jugador = hit.transform.GetComponent<Jugador>();
            if (jugador != null)
            {
                jugador.takeDamage(selfPlayer.dmg);
            }
        }
        */
    }
}