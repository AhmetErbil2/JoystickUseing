using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera1 : MonoBehaviour
{
    public Transform PlayerLocation;
    Vector3 fark;
    void Start()
    {
        fark= transform.position-PlayerLocation.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
