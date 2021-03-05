using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapePart : MonoBehaviour
{
    public bool created = false;
    MeshRenderer mr;

    void Awake()
    {
        mr = GetComponent<MeshRenderer>();
    }


    public void Show() 
    {
        created = true;
        mr.enabled = true;
    }

    public void Unshow() 
    {
        created = false;
        mr.enabled = false;
    }
}
