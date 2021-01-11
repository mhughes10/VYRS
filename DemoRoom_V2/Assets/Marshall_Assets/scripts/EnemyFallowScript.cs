using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFallowScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed;
    public GameObject player;
    private bool fallow = false;
    // current distance 
    private float currDist;
    private float fallowDist;
    void Update()
    {
        DeterFallow(currDist, fallowDist, fallow);
        FallowMethod(player);
        /*currDist= Vector3.Distance(transform.position, player.transform.position);
        

        if (currDist > fallowDist)
        {
            fallow = true;
        }

        else if (currDist < fallowDist)
        {
            fallow = false;
        }

        if (fallow == true)
        {
            // do nothing

        }

        else if (fallow == false)
        {
            Vector3 localPosition = player.transform.position - transform.position;
            localPosition = localPosition.normalized; // The normalized direction in LOCAL space
            transform.Translate(localPosition.x * Time.deltaTime * speed, localPosition.y * Time.deltaTime * speed, localPosition.z * Time.deltaTime * speed);
        } */


    }

    /*Vector3 localPosition = player.transform.position - transform.position;
    localPosition = localPosition.normalized; // The normalized direction in LOCAL space
    transform.Translate(localPosition.x * Time.deltaTime * speed, localPosition.y * Time.deltaTime * speed, localPosition.z * Time.deltaTime * speed);*/
    public bool DeterFallow(float x, float y, bool z)
    {
        x = Vector3.Distance(transform.position, player.transform.position);
        


        if (x > y)
        {
            z = true;
        }

        else if (x < y)
        {
            z = false;
        }

        return z;
    }

    private void FallowMethod(GameObject player)
    {
        if (DeterFallow(currDist, fallowDist, fallow) == false)
        {
            Vector3 localPosition = player.transform.position - transform.position;
            localPosition = localPosition.normalized; // The normalized direction in LOCAL space
            transform.Translate(localPosition.x * Time.deltaTime * speed, localPosition.y * Time.deltaTime * speed, localPosition.z * Time.deltaTime * speed);

        }

        else if (DeterFallow(currDist, fallowDist, fallow) == true)
        {
            //do nothing
        }


    }


}







