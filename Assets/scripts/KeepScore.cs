using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class  KeepScore : MonoBehaviour
{   public static int Score = 0;
    void OnGUI()

    {
        // Create style for a button
        GUIStyle myButtonStyle = new GUIStyle(GUI.skin.button);
        myButtonStyle.fontSize = 100;
        // Load and set Font
        Font myFont = (Font)Resources.Load("Fonts/JazzCreateBubble", typeof(Font));
        myButtonStyle.font = myFont;
        // Set color for selected and unselected buttons
        myButtonStyle.normal.textColor = Color.white;
        myButtonStyle.hover.textColor = Color.black;
        // use style in button
        GUI.backgroundColor = Color.blue ;
        bool testButtonTwo = GUI.Button(new Rect(100, 200, 200, 200), "Score"+"\n"+Score.ToString(), myButtonStyle);


    }

}

