using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float followSpeed = 0.125f;
    [SerializeField] Vector3 offSet;


    private void LateUpdate()
    {
        transform.position = target.position + offSet;
    }

}
