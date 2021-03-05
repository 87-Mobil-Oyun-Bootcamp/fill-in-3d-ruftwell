using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeBuilder : MonoBehaviour
{
    public static ShapeBuilder Instance;
    ShapePart[] parts;
    int partsCount = 0;
    int maxParts = 999;

    void Awake()
    {
        Instance = this;
    }



    // Start is called before the first frame update
    void Start()
    {
        parts = FindObjectsOfType<ShapePart>();
        for (int i = 0; i < parts.Length; i++)
        {
            parts[i].Unshow();
        }

        maxParts = parts.Length;
    }

    public void AddPart()
    {
        if (partsCount <= maxParts)
        {
            parts[partsCount].Show();
            partsCount += 1;
        }
    }

}
