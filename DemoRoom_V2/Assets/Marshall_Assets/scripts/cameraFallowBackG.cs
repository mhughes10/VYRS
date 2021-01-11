using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFallowBackG : MonoBehaviour
{
    
    [SerializeField] private float yOff;
    [SerializeField] private float xOff;
    public Transform target;
    public float smoothTime = 0.3F;
    private Vector2 velocity = Vector2.zero;

    void Update()
    {
        // Define a target position above and behind the target transform
        Vector2 targetPosition = target.TransformPoint(new Vector2(xOff, yOff));
       
            // Smoothly move the camera towards that target position
            transform.position = Vector2.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
        

     
    }
}