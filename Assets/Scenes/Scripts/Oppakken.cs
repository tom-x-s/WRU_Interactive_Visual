using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oppakken : MonoBehaviour
{
    public GameObject PObject;

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
        if (Input.GetKey(KeyCode.F))
        {
            this.transform.position = new Vector3(PObject.transform.position.x, PObject.transform.position.y + 0.6f, PObject.transform.position.z + 0.5f);
            this.transform.SetParent(PObject.transform);
            GetComponent<Collider>().enabled = false; 
        }
    }
}
