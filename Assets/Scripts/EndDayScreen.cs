using UnityEngine;
using System.Collections;
using System;

public class EndDayScreen : MonoBehaviour
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
        if (GUILayout.Button("Novice", GUILayout.Height(50), GUILayout.Width(100)))
        {
            Application.LoadLevel("News");
        }
        scrollPosition = GUILayout.BeginScrollView(scrollPosition, GUILayout.Width(area.width), GUILayout.Height(area.height - 50));

        GUILayout.BeginHorizontal("box", GUILayout.MaxHeight(200));

        GUILayout.BeginVertical();
		GUILayout.Label("Ponudba: ", h1, GUILayout.Height(40));
		GUILayout.Label("Povpraševanje: ", h1, GUILayout.Height(40));
		GUILayout.Label("Predviden dobiček: ", h1, GUILayout.Height(40));
		GUILayout.Label("Premoženje: ", h1, GUILayout.Height(40));
        GUILayout.EndVertical();

        GUILayout.BeginVertical();
		GUILayout.Label(String.Format("{0} kepic", GameState.state.supply), GUILayout.Height(40));
		GUILayout.Label(String.Format("{0} kepic", GameState.state.demand), GUILayout.Height(40));
		GUILayout.Label(String.Format("{0} * -0.8€ + {1} * {2}€ = {3}", GameState.state.supply, GameState.state.demand, GameState.state.cena, GameManager.profit()/100), GUILayout.Height(40));
		GUILayout.Label(String.Format("{0}€", GameState.state.premozenje), GUILayout.Height(40));
        GUILayout.EndVertical();

		GUILayout.BeginVertical();
		if (GUILayout.Button("Trgovina", GUILayout.Height(40)))
		{
			Application.LoadLevel("Shop");
		}
		GUILayout.EndVertical();

        GUILayout.BeginVertical();
        if (GUILayout.Button("Pomoč", GUILayout.Height(40)))
        {
            HelpDisplay.Open(HelpManager.HelpType.lowerDemand);
        }
        if (GUILayout.Button("Pomoč", GUILayout.Height(40)))
        {
            HelpDisplay.Open(HelpManager.HelpType.lowerDemand);
        }
        GUILayout.EndVertical();

        GUILayout.EndHorizontal();

		if(GameState.state.daysLeft <= 0){
			GUILayout.Button("Konec igre", GUILayout.Height(50));
		}
		else
		{
			if (GUILayout.Button("Naslednji dan", GUILayout.Height(50)))
			{
				GameManager.applyNewDay();
			}
		}
		GUILayout.Label ("Preostalo dni:" + GameState.state.daysLeft);
        GUILayout.EndScrollView();
        GUILayout.EndVertical();
        GUILayout.EndArea();
    }
}
