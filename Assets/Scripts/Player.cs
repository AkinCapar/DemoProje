using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Vector3 startPoint;
    [SerializeField] Vector3 paintingPoint;
    [SerializeField] GameObject mainCamera;
    [SerializeField] GameObject paintingCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            transform.position = new Vector3 (startPoint.x, startPoint.y, startPoint.z);
        }

        if(collision.gameObject.tag == "FinishZone")
        {
            GetComponent<SwerveMovement>().enabled = false;
            GetComponent<SwervingInputSystem>().enabled = false;
          //  GetComponent<Paintable>().enabled = true;
            mainCamera.SetActive(false);
            paintingCamera.SetActive(true);
            transform.position = new Vector3(paintingPoint.x, paintingPoint.y, paintingPoint.z);
        }
    }

}
