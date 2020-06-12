using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gangpadlicht : MonoBehaviour
{
    public int countCollisions = 0;
    int colorPicker = 0;
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.color = Color.green;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Sphere")
        {
            countCollisions++;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Sphere")
        {
            countCollisions--;
        }
    }

    void Update ()
    {
        if (countCollisions < 2)
        {
            colorPicker = Random.Range(0, 0);
            switch (colorPicker)
            {
                case 0: rend.material.color = Color.green; break;

            }
        }
        if (countCollisions == 2)
        {
            colorPicker = Random.Range(0, 0);
            switch (colorPicker)
            {
                case 0: rend.material.color = Color.red; break;

            }
           
        }
        if (countCollisions > 2)
        {
            countCollisions = 0;
        }

    }

    
}
