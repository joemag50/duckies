using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Float : MonoBehaviour
{
    public GameObject WaterLevel;

    private float waterlevel;
    private float floatHeight;

    private void Start()
    {
        waterlevel = WaterLevel.GetComponent<Transform>().position.y;
        floatHeight = waterlevel + Juego.floatingPoint;
    }

    public void Update()
    {
        Vector3 velo = GetComponent<Rigidbody>().velocity;
        
        if (transform.position.y < floatHeight)
            GetComponent<Rigidbody>().velocity = new Vector3(velo.x, Juego.jumpingForce, velo.z);
    }
}
