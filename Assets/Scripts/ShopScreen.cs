using UnityEngine;
using System.Collections;
using System;

public class ShopScreen : MonoBehaviour {
	private Rect area = new Rect();
	public GUISkin skin;
	public Vector2 scrollPosition;

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
		
		GUILayout.BeginHorizontal("box", GUILayout.MaxHeight(200));
		
		GUILayout.BeginVertical();
		GUILayout.Label("Naroči sladoled ", h1, GUILayout.Height(120));
		GUILayout.EndVertical();

		GUILayout.BeginVertical();
		if (GUILayout.Button("+", GUILayout.Height(40)))
		{
			GameState.state.supply += 100;
		}
		GUILayout.Label(String.Format("naslednji dan {0} kepic x 0.8€", GameState.state.supply), GUILayout.Height(40));
		if (GUILayout.Button("-", GUILayout.Height(40)))
		{
			GameState.state.supply -= 100;
		}
		GUILayout.EndVertical();
		
		GUILayout.EndHorizontal();

		GUILayout.EndScrollView();
		GUILayout.EndVertical();
		GUILayout.EndArea();
	}
}
