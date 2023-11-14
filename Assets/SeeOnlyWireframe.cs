// from http://docs.unity3d.com/ScriptReference/GL-wireframe.html
using UnityEngine;

public class ExampleClass : MonoBehaviour
{
    void OnPreRender()
    {
        GL.wireframe = true;
    }
    void OnPostRender()
    {
        GL.wireframe = false;
    }
}