using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Add this Script Directly to The Death Zone
public class boing : MonoBehaviour
{
    public AudioClip saw;    // Add your Audi Clip Here;
                             // This Will Configure the  AudioSource Component; 
                             // MAke Sure You added AudioSouce to death Zone;
    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = saw;
    }

    void OnTriggerEnter(Collider other)  //Plays Sound Whenever collision detected
    {
        if (other.gameObject.name == "Sphere")
        {

            GetComponent<AudioSource>().Play();
        }
    }
    // Make sure that deathzone has a collider, box, or mesh.. ect..,
    // Make sure to turn "off" collider trigger for your deathzone Area;
    // Make sure That anything that collides into deathzone, is rigidbody;
}
