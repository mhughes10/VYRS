using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sanitySwapController : MonoBehaviour
{
    public GameObject[] objectToBeDisabled1;
    public GameObject[] objectToBeDisabled2;
    [SerializeField] private bool enabler;
    public bool swapVar;
    // Start is called before the first frame update
    void Start()
    {
        objectToBeDisabled1 = GameObject.FindGameObjectsWithTag("Org");
        objectToBeDisabled2 = GameObject.FindGameObjectsWithTag("Alt");
        enabler = true;
    }

    // Update is called once per frame
    void Update()
    {
        activeObject();

        if (enabler == true)
        {
            foreach (GameObject obj in objectToBeDisabled1)
            {
                obj.SetActive(true);
            }
            foreach (GameObject obj in objectToBeDisabled2)
            {
                obj.SetActive(false);
            }
        }

        if (enabler == false)
        {
            foreach(GameObject obj in objectToBeDisabled1)
            {
                obj.SetActive(false);
            }
            foreach (GameObject obj in objectToBeDisabled2)
            {
                obj.SetActive(true);
            }
            

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

