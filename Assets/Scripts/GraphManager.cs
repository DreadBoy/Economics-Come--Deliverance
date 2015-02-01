using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GraphManager : MonoBehaviour {
	
	public static List<Graph> graphs = new List<Graph>();
	// Use this for initialization
	void Start () {
		graphs.Add (new Graph (new Line (new Vector2 (0, 0), new Vector2 (1, 1))));
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public enum GraphType
	{
		normal = 0
	}
}
