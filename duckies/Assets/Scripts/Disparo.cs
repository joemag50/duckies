using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject prefabBala;
    GameObject bala;

    // Start is called before the first frame update
    void Start()
    {
        bala = Instantiate(prefabBala, GetComponentInParent<Transform>().position, Quaternion.identity);
        bala.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
