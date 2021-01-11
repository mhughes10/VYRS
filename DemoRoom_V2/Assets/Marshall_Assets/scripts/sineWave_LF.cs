using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sineWave_LF : MonoBehaviour
{
    /// <summary>The objects initial position.</summary>
    private Vector2 startPosition;
    /// <summary>The objects updated position for the next frame.</summary>
    private Vector2 newPosition;

    /// <summary>The speed at which the object moves.</summary>
    [SerializeField] private float speed = 3f;
    /// <summary>The maximum distance the object may move in either y direction.</summary>
    [SerializeField] private float maxDistance = 1f;

    void Start()
    {
        startPosition = transform.position;
        newPosition = transform.position;
    }

    void Update()
    {
        newPosition.x = startPosition.x + (maxDistance * Mathf.Sin(Time.time * speed));
        transform.position = newPosition;
    }
}
