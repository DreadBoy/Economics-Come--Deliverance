using UnityEngine;
using System.Collections;

public class TestGraph : MonoBehaviour {
    private Material mat;
    static Material lineMaterial;
    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForEndOfFrame();
            //if (!mat)
            //    mat = new Material("Shader \"Hidden/Alpha\" {" + "SubShader {" + "    Pass {" + "        ZTest Always Cull Off ZWrite Off" + "        Blend DstAlpha Zero" + "        Color (1,1,1,1)" + "    }" + "}" + "}");

            //GL.PushMatrix();
            //GL.LoadOrtho();
            //int i = 0;
            //while (i < mat.passCount)
            //{
            //    mat.SetPass(i);
            //    GL.Begin(GL.QUADS);
            //    GL.Vertex3(0, 0, 0.1F);
            //    GL.Vertex3(1, 0, 0.1F);
            //    GL.Vertex3(1, 1, 0.1F);
            //    GL.Vertex3(0, 1, 0.1F);
            //    GL.End();
            //    ++i;
            //}
            //GL.PopMatrix();
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
}
