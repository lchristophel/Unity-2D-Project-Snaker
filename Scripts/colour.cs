using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colour : MonoBehaviour
{
    public List<Material> Colors = new List<Material>();

    private void Awake() 
    {
        GetComponent<Renderer>().material = Colors[Random.Range(0, Colors.Count)];  
    }
}
