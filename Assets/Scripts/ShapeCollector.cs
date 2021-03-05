using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeCollector : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "ShapeBuilder")
        {
            ShapeBuilder.Instance.AddPart();
            Destroy(gameObject);
        }
    }

}
