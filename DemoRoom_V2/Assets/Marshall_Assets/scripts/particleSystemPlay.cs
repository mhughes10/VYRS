using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleSystemPlay : MonoBehaviour
{
    public ParticleSystem particle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            gameObject.SetActive(true);
            particle.Play();
        }
    }
}
