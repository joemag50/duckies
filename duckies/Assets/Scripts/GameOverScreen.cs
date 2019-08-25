using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    // 200x300 px window will apear in the center of the screen.
    private Rect windowRect = new Rect((Screen.width - 200) / 2, (Screen.height - 300) / 2, 200, 300);
    // Only show it if needed.
    private bool show = false;

    void OnGUI()
    {
        if (show)
            windowRect = GUI.Window(0, windowRect, DialogWindow, "Congratulations");
    }

    // This is the actual window.
    void DialogWindow(int windowID)
    {
        float y = 20f;
        GUI.Label(new Rect(5, y, windowRect.width, 20), "Again?");

        if (GUI.Button(new Rect(5, y+30, windowRect.width - 10, 20), "Restart"))
        {
            SceneManager.LoadScene("Main");
            show = false;
        }

        if (GUI.Button(new Rect(5, y+60, windowRect.width - 10, 20), "Exit"))
        {
            Application.Quit();
            show = false;
        }
    }

    // To open the dialogue from outside of the script.
    public void Open()
    {
        show = true;
    }

    public void Close()
    {
        show = false;
    }
}
