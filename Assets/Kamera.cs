using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class Kamera : MonoBehaviour
{
    Vector3 fark;
    public Transform Playerlocation;
    void Start()
    {
        fark = transform.position - Playerlocation.position;
    }

 
    
}
