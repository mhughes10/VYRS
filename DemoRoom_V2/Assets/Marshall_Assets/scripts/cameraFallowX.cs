using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFallowX : MonoBehaviour
{
    public GameObject player;
    
    public float yOff;
    public float zOff;

    //wait for lateupdate
    void LateUpdate()
    {
        transform.position = new Vector3(player.transform.position.x, yOff, zOff);
    }
}

