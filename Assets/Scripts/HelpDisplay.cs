using UnityEngine;
using System.Collections;

public class HelpDisplay : MonoBehaviour
{

    public Rect windowRect;
    public GUISkin skin;
    static Help help;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnGUI()
    {
		if (help == null)
			return;

        windowRect.width = (new CSS()).width("96%").width();
        windowRect.height = (new CSS()).height("96%").height();
        windowRect.x = (new CSS()).width("2%").width();
        windowRect.y = (new CSS()).height("2%").height();

        GUI.skin = skin;

        windowRect = GUILayout.Window(0, windowRect, DoMyWindow, "Ekonomska pomoč");
    }

    void DoMyWindow(int windowID)
    {
        GUIStyle h1 = new GUIStyle(skin.label);
        h1.fontSize = 20;
        h1.margin = new RectOffset(0, 0, 50, 0);

        GUILayout.Label(help.title, h1);
        GUILayout.Label(help.body);
        if (GUI.Button(new Rect(windowRect.width - 43, 3, 41, 41), "X"))
        {
            HelpDisplay.Close();
        }
    }

    public static void Open(HelpManager.HelpType helpType)
    {
        int index = (int)helpType;
        help = HelpManager.helps[index];
    }

    public static void Close()
    {
        help = null;
    }
}
