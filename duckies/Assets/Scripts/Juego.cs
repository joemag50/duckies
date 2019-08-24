using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Juego : MonoBehaviour
{
    static public float floatingPoint = 2f;
    static public float jumpingForce = 7f;
    static public float speed = 15f;
    static public float speedG = 5f;

    public GameObject Prefab;
    public Transform pos;
    public GameObject waterPlane;

    GameObject player1, player2;

    // Use this for initialization
    void Awake()
    {
        waterPlane = Instantiate(waterPlane, new Vector3(0f, -95f, 0f), Quaternion.identity);
    }

    void Start()
    {
        player1 = Instantiate(Prefab, pos.position, Quaternion.identity);
        player1.GetComponent<mov>().horizontal="Horizontal";
        player1.GetComponent<mov>().vertical = "Vertical";
        player1.GetComponent<Float>().WaterLevel = waterPlane;

        player2 = Instantiate(Prefab, pos.position, Quaternion.identity);
        player2.GetComponent<mov>().horizontal="Horizontal2";
        player2.GetComponent<mov>().vertical="Vertical2";
        player2.GetComponent<Float>().WaterLevel = waterPlane;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
