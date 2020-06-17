using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oppakken : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.F) && other.gameObject.name == "18534_Shopping_Cart")
        {
            this.transform.position = new Vector3(other.transform.position.x, other.transform.position.y + 0.6f, other.transform.position.z);
            this.transform.SetParent(other.transform);
            GetComponent<Collider>().enabled = false; 
        }
    }
}
