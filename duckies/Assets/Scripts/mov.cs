using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov : MonoBehaviour
{
    float speed;
    float speedG;
    public string horizontal, vertical;

    private void Start()
    {
        speed = Juego.speed;
        speedG = Juego.speedG;
    }

    // Update is called once per frame
    void Update()
    {
        if (Juego.paused)
            return;

        //Debug.Log("horizontal: "+horizontal);
        //Debug.Log("vertical: " + vertical);
        float axisX = Input.GetAxis(horizontal) * speedG;
        float axisY = Input.GetAxis(vertical) * speed;
        Vector3 velo = GetComponent<Rigidbody>().velocity;

        if (Input.GetKey("up") || Input.GetKey("w") || Input.GetKey("s") || Input.GetKey("down"))
        {
            transform.Translate(new Vector3(axisY, velo.y, velo.z) * Time.deltaTime);
        } else {
            GetComponent<Rigidbody>().velocity = new Vector3(0f, velo.y, 0f);
        }

        if (Input.GetKey("left") || Input.GetKey("right") || Input.GetKey("a") || Input.GetKey("d"))
            transform.Rotate(new Vector3(0, axisX, 0));
        
    }
}
