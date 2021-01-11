using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sanitySwapcontrollerMoving : MonoBehaviour
{
    
    [SerializeField] private bool enabler;
    public bool swapVar;
    // Start is called before the first frame update
    void Start()
    {
       
        enabler = true;
    }

    // Update is called once per frame
    void Update()
    {
       
        activeObject();

        if (enabler == true)
        {
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;
        }

        if (enabler == false)
        {
            GetComponent<SpriteRenderer>().enabled = true;
            GetComponent<BoxCollider2D>().enabled = true;
        }
    }
    public void activeObject()
    {
        if (enabler == true)
        {
            swapVar = true;
        }

        if (enabler == false)
        {
            swapVar = false;
        }

        if (Input.GetKeyDown(KeyCode.RightShift) && swapVar == true)
        {
            enabler = false;
            
        }

        if (Input.GetKeyDown(KeyCode.RightShift) && swapVar == false )
        {
            enabler = true;
            
        }
    }
}
