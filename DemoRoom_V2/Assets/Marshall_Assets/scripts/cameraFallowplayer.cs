using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFallowplayer : MonoBehaviour
{
    public PlayerController pCRef;
    public bool isGrounded;
    [SerializeField] public float xOff;
    [SerializeField] public float yOff;
    [SerializeField] public float zOff = -214f;
    public Transform target;
    public float smoothTime = 0.3F;
    private Vector3 velocity = Vector3.zero;

    private void Start()
    {

        pCRef.isGrounded = true;
    }
    void Update()
    {

        if (pCRef.isGrounded == false)
        {
            smoothTime = .05f;
        }

       else
        {
            smoothTime = .3f;
        }

    }
    private void FixedUpdate()
    {
        // Define a target position above and behind the target transform
        Vector3 targetPosition = target.TransformPoint(new Vector3(xOff, yOff, zOff));

        // Smoothly move the camera towards that target position
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }

}
