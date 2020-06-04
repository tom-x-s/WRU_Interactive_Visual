using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waggiemove : MonoBehaviour
{
    public float acceleration = 0.0f;
    // Use this for initialization
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        MoveCharacter();
        RotateCharacter();
    }
    //Gathers input to move the character
    void MoveCharacter()
    {
        //If the player presses W
        if (Input.GetKey(KeyCode.W))
        {
            //Increase forward acceleration
            if (acceleration < 5.0f)
            {
                acceleration += 0.1f;
            }
        }
        //If the player presses S
        if (Input.GetKey(KeyCode.S))
        {
            //Accelerate in the reverse direction.
            if (acceleration < 5.0f)
            {
                acceleration -= 0.1f;
            }
        }
        //If the player is not pressing forward or backward.
        if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S))
        {
            //Decrease acceleration.
            if (acceleration > 0.0f)
            {
                acceleration -= 0.1f;
            }
        }
        //Compensate for floating point imprecision.
        //If the player is not supposed to be moving, explicitly tell him so.
        if (acceleration > -0.05f && acceleration < 0.05f)
        {
            acceleration = 0.0f;
        }
        //Move the character in its own forward direction while taking acceleration and time into account.
        //The Time.deltaTime maintains consistent speed across all machines by syncing the speed with time.
        //Here is where the magic happens.
        transform.Translate(transform.forward * acceleration * Time.deltaTime, Space.World);
    }
    //Roteert het wagentje
    void RotateCharacter()
    {
        //Als jj D indrukt
        if (Input.GetKey(KeyCode.D))
        {
            //Roteert het object waar de code op staat de transform, waarbij deltaTime gebruikt wordt zodat het op elk apparaat hetzelfde uitkomt.
            transform.Rotate(transform.up, 100.0f * Time.deltaTime, Space.World);
        }
        //Als je A indrukt
        if (Input.GetKey(KeyCode.A))
        {
            //Roteert het object waar de code op staat de transform, waarbij deltaTime gebruikt wordt zodat het op elk apparaat hetzelfde uitkomt.
            transform.Rotate(transform.up, -100.0f * Time.deltaTime, Space.World);
        }
    }
}
