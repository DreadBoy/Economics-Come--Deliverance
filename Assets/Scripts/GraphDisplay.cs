using UnityEngine;
using System.Collections;

public class GraphDisplay : MonoBehaviour {

    static Material lineMaterial;
	static Graph graph = null;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    static void CreateLineMaterial()
    {
        if (!lineMaterial)
        {
            lineMaterial = new Material("Shader \"Lines/Colored Blended\" {" +
                "SubShader { Pass { " +
                "    Blend SrcAlpha OneMinusSrcAlpha " +
                "    ZWrite Off Cull Off Fog { Mode Off } " +
                "    BindChannels {" +
                "      Bind \"vertex\", vertex Bind \"color\", color }" +
                "} } }");
            lineMaterial.hideFlags = HideFlags.HideAndDontSave;
            lineMaterial.shader.hideFlags = HideFlags.HideAndDontSave;
        }
    }

    void OnPostRender()
    {
        if (graph == null)
            return;
        CreateLineMaterial();
        // set the current material
        lineMaterial.SetPass(0);
        GL.Begin(GL.LINES);
        GL.Color(new Color(1, 1, 1, 0.5f));
        GL.Vertex3(0, 0, 0);
        GL.Vertex3(1, 0, 0);
        GL.Vertex3(0, 1, 0);
        GL.Vertex3(1, 1, 0);
        GL.Vertex3(0, 0, 0);
        GL.Vertex3(0, 1, 0);
        GL.Vertex3(1, 0, 0);
        GL.Vertex3(1, 1, 0);
        GL.End();
    }

	
	public static void Show(GraphManager.GraphType graphType){
		int index = (int)graphType;
		graph = GraphManager.graphs[index];
	}

    public static void Hide()
    {
        graph = null;
    }

}
