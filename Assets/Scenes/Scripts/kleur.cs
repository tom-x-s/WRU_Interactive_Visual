using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kleur : MonoBehaviour
{
    int colorPicker = 0;
    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Sphere")
        {
            colorPicker = Random.Range(0, 0);
            switch (colorPicker)
            {
                case 0: rend.material.color = Color.green; break;

            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Sphere")
        {
            colorPicker = Random.Range(0, 0);
            switch (colorPicker)
            {
                case 0: rend.material.color = Color.red; break;

            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
       
            colorPicker = Random.Range(0, 0);
            switch (colorPicker)
            {
                case 0: rend.material.color = Color.green; break;

            }
        
    }
}
