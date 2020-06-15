using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gangpadlicht : MonoBehaviour
{
    public int countCollisions = 0;
    //int colorPicker = 0;
    //Renderer rend;
    public Material ColourGreen;
    public Material ColourRed;

    void Start()
    {
        //rend = GetComponent<Renderer>();
       // rend.material.color = Color.green;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "18534_Shopping_Cart")
        {
            countCollisions++;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "18534_Shopping_Cart")
        {
            countCollisions--;
        }
    }

    void Update ()
    {
        if (countCollisions < 2)
        {
            //colorPicker = Random.Range(0, 0);
            //switch (colorPicker)
            //{
            //     case 0: rend.material.color = Color.green; break;

            // }
            GetComponent<MeshRenderer>().material = ColourGreen;
        }
        if (countCollisions == 2)
        {
            //colorPicker = Random.Range(0, 0);
            // switch (colorPicker)
            // {
            //     case 0: rend.material.color = Color.red; break;

            // }
            GetComponent<MeshRenderer>().material = ColourRed;

        }
        if (countCollisions > 2)
        {
            countCollisions = 0;
        }

    }

    
}
