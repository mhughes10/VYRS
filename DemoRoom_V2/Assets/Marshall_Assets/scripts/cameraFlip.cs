using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFlip : MonoBehaviour
{
    public float var1;
    public float var2;
    new Camera camera;
    public bool flipHorizontal;
    void Awake()
    {
        camera = GetComponent<Camera>();
    }

    private void Update()
    {
        if (camera.orthographicSize > 0)
        {
            var1 = 1;
            var2 = 1;
        }

        else
        {
            var1 = -1;
            var2 = -1;
        }
    }
    void OnPreCull()
    {
        camera.ResetWorldToCameraMatrix();
        camera.ResetProjectionMatrix();
        Vector3 scale = new Vector3(flipHorizontal ? -1 : var1, var2, 1);
        camera.projectionMatrix = camera.projectionMatrix * Matrix4x4.Scale(scale);
    }
    void OnPreRender()
    {
        GL.invertCulling = flipHorizontal;
    }

    void OnPostRender()
    {
        GL.invertCulling = false;
    }
}
