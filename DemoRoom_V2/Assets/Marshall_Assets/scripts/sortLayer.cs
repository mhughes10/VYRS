using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(ParticleSystem))]
public class sortLayer : MonoBehaviour
{
    // Start is called before the first frame update
    // this helps place the particle system in a layer of your chosing.
    void Start()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
       GetComponent<Renderer>().sortingLayerID = spriteRenderer.sortingLayerID;
       GetComponent<Renderer>().sortingOrder = spriteRenderer.sortingOrder;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
