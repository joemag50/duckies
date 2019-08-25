using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraMovement : MonoBehaviour
{
    public RectTransform posStart, posMode, pos1P, pos2P, posHowToPlay, posCredits;
    Vector3 posNext;

    bool arrived;
    float speed = 500f;

    // Start is called before the first frame update
    void Start()
    {
        // TODO; Add animation of legs
        posNext = transform.position;
        arrived = false;
        MoveCamera(0);
    }

    // Update is called once per frame
    void Update()
    {
        if (!arrived)
            transform.position = Vector3.MoveTowards(transform.position, posNext + new Vector3(0, 0, -390), Time.deltaTime * speed);

        if (transform.position == posNext + new Vector3(0, 0, -390))
            arrived = true;
    }

    public void MoveCamera(int option)
    {
        arrived = false;
        switch(option)
        {
            case 0:
                //transform.position = Vector3.MoveTowards(transform.position, posStart.position + new Vector3(0, 0, -100), Time.deltaTime);
                posNext = posStart.position;
                //posAux.position = this.GetComponent<Transform>().position;
                break;
            case 1:
                //transform.position = Vector3.MoveTowards(transform.position, posMode.position + new Vector3(0, 0, -100), Time.deltaTime);
                posNext = posMode.position;
                //posAux.position = this.GetComponent<Transform>().position;
                break;
            case 2:
                //transform.position = Vector3.MoveTowards(transform.position, pos1P.position + new Vector3(0, 0, -100), Time.deltaTime);
                posNext = pos1P.position;
                //posAux.position = this.GetComponent<Transform>().position;
                break;
            case 3:
                //transform.position = Vector3.MoveTowards(transform.position, pos2P.position + new Vector3(0, 0, -100), Time.deltaTime);
                posNext = pos2P.position;
                //posAux.position = this.GetComponent<Transform>().position;
                break;
            case 4:
                //transform.position = Vector3.MoveTowards(transform.position, posHowToPlay.position + new Vector3(0, 0, -100), Time.deltaTime);
                posNext = posHowToPlay.position;
                //posAux.position = this.GetComponent<Transform>().position;
                break;
            case 5:
                //transform.position = Vector3.MoveTowards(transform.position, posCredits.position + new Vector3(0, 0, -100), Time.deltaTime);
                posNext = posCredits.position;
                //posAux.position = this.GetComponent<Transform>().position;
                break;
            default:
                //this.GetComponent<Transform>().position = posAux.position + new Vector3(0, 0, -100);
                break;
        }
    }

    public void GoToGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void SelectChar1Plus()
    {
        StaticVariables.opPlayer1++;
    }
    public void SelectChar1Minus()
    {
        StaticVariables.opPlayer1--;
    }
    public void SelectChar2Plus()
    {
        StaticVariables.opPlayer2++;
    }
    public void SelectChar2Minus()
    {
        StaticVariables.opPlayer2--;
    }
}
