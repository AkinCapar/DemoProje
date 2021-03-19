using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Paintable : MonoBehaviour
{
    [SerializeField] GameObject brush;
    [SerializeField] float brushSize = 0.1f;
    [SerializeField] float brushAdjust = 0.1f;
    public int brushCount;
    [SerializeField] Text paintingPercentageText;

    float paintPercentage;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Paint();
        int brushCount = GameObject.FindGameObjectsWithTag("brush").Length;

        paintPercentage = Mathf.RoundToInt(brushCount / 6.5f);
        paintingPercentageText.GetComponent<Text>().text = paintPercentage.ToString();

        if (paintPercentage >= 100)
        {
            FindObjectOfType<SceneLoader>().ActivateWinCanvas();
        }
    }

    private void Paint()
    {
            if (Input.GetMouseButton(0))
            {
                var Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(Ray, out hit))
                {
                    if (hit.collider.gameObject.tag == "PaintingPlane" && paintPercentage < 100)
                    {
                        var paint =  Instantiate(brush, hit.point + Vector3.back * brushAdjust, Quaternion.Euler(-90f, 0f, 0f), transform);
                        paint.transform.localScale = Vector3.one * brushSize;
                    }

                    else { return; }
                }
            }
    }
}
