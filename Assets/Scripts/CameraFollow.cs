using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Vector3 offSet;
    [SerializeField] Vector3 camRotation;


    private void LateUpdate()
    {
        transform.position = target.position + offSet;
        transform.rotation = Quaternion.Euler(camRotation);
    }

}
