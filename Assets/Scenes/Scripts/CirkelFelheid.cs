using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CirkelFelheid : MonoBehaviour
{
    private Vector3 ownPosition;
    private Component[] foundObjects;
    private List<GameObject> OtherObjects = new List<GameObject>();
    private float[] distances;
    private float lowestDistance;

    public Transform Cirkel;

    // Start is called before the first frame update
    void Start()
    {
        ownPosition = gameObject.transform.position;
        foundObjects = Object.FindObjectsOfType<CirkelFelheid>();

        foreach(Component foundObject in foundObjects)
        {
            if (foundObject.gameObject.transform.position != ownPosition)
            {
                OtherObjects.Add(foundObject.gameObject);
            }
        }
        distances = new float[OtherObjects.Count];
    }

    // Update is called once per frame
    void Update()
    {
        ownPosition = gameObject.transform.position;

        for (int i=0; i <= OtherObjects.Count-1; i++)
        {
            float dist = Vector3.Distance(OtherObjects[i].transform.position, ownPosition);
            distances[i] = dist;
        }

        lowestDistance = distances.Min();
        float trueOpacity = 1 - (lowestDistance / 10);
        float opacity;
        if (trueOpacity <= 1 && trueOpacity >= 0)
        {
            opacity = trueOpacity;
        }
        else if(trueOpacity < 0)
        {
            opacity = 0.0f;
        }
        else
        {
            opacity = 1.0f;
        }

        Cirkel.GetComponent<MeshRenderer>().material.color = new Color(1.0f, 0.92f, 0.016f, opacity);
    }
}
