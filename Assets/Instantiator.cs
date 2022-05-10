using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{

    public GameObject prefab;
    public int clones;
    public float grados;
    public void CloneObject()
    {

        GameObject clon;
        for (int i = 0; i < clones; i++)
        {
            clon = Instantiate(prefab);
            clon.transform.Rotate(0, grados * i, 0);
            clon.transform.Translate(i, i, 0);
            
            //Destroy(clon, 2)
        }
        
    }
}
