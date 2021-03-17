using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paintable : MonoBehaviour
{
    [SerializeField] GameObject brush;
    [SerializeField] float brushSize = 0.1f;
    [SerializeField] float brushAdjust = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Paint();
        
    }

    private void Paint()
    {
            if (Input.GetMouseButton(0))
            {
                var Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(Ray, out hit))
                {
                    if (hit.collider.gameObject.tag == "PaintingPlane")
                    {
                        var go = Instantiate(brush, hit.point + Vector3.back * brushAdjust, Quaternion.Euler(-90f, 0f, 0f), transform);
                        go.transform.localScale = Vector3.one * brushSize;
                    }

                    else { return; }
                }
            }
    }
}
