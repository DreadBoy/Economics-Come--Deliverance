using UnityEngine;
using System.Collections;

public class NewsScreen : MonoBehaviour
{
    private Rect area = new Rect();
    public GUISkin skin;
    public Vector2 scrollPosition;
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
        GUI.skin = skin;


        area.width = (new CSS()).width("96%").width();
        area.height = (new CSS()).height("96%").height();
        area.x = (new CSS()).width("2%").width();
        area.y = (new CSS()).height("2%").height();

        GUIStyle h1 = new GUIStyle(skin.label);
        h1.fontSize = 20;

        GUILayout.BeginArea(area);
        GUILayout.BeginVertical();
        if (GUILayout.Button("Nazaj", GUILayout.Height(50), GUILayout.Width(100)))
        {
            Application.LoadLevel("EndDay");
        }
        scrollPosition = GUILayout.BeginScrollView(scrollPosition, GUILayout.Width(area.width), GUILayout.Height(area.height - 50));

        for (int i = 0; i < NewsManager.news.Count; i++)
        {
            GUILayout.BeginHorizontal("box", GUILayout.MaxHeight(200));
            GUILayout.Label(Resources.Load<Texture>("Images/Reports/" + NewsManager.news[i].type.ToString()), GUILayout.Width(100), GUILayout.Height(100));
            GUILayout.BeginVertical();
            GUILayout.Label(NewsManager.news[i].title, h1);
            GUILayout.Label(NewsManager.news[i].message);
            GUILayout.BeginHorizontal();
            if (GUILayout.Button("Skrij", GUILayout.Height(50)))
            {
                EffectManager.affect(NewsManager.news[i].effect);
                NewsManager.news.RemoveAt(i);
            }
            if (GUILayout.Button("Pomoč", GUILayout.Height(50)))
            {
				HelpDisplay.Open(HelpManager.HelpType.lowerDemand);
            }
            GUILayout.EndHorizontal();
            GUILayout.EndVertical();
            GUILayout.EndHorizontal();
        }

        GUILayout.EndVertical();
        GUILayout.EndScrollView();
        GUILayout.EndArea();
    }
}
