using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwervingInputSystem : MonoBehaviour
{
    private float lastFrameFingerPositionX;
    private float moveFactorX;
    public float MoveFactorX => moveFactorX;
    [SerializeField] float runSpeed = 1f;
    [SerializeField] float rotationSpeed = 1f;
    Animator myAnimator;

    private void Start()
    {
        myAnimator = GetComponent<Animator>();
    }


    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            lastFrameFingerPositionX = Input.mousePosition.x;
        }

        else if(Input.GetMouseButton(0))
        {
            myAnimator.SetBool("isRunning", true);
            moveFactorX = Input.mousePosition.x - lastFrameFingerPositionX;
            transform.position += transform.forward * Time.deltaTime * runSpeed;
            lastFrameFingerPositionX = Input.mousePosition.x;
            float h = rotationSpeed * Input.GetAxis("Mouse X");
            transform.Rotate(0, h, 0);

        }

        else if(Input.GetMouseButtonUp(0))
        {
            moveFactorX = 0f; 
        }

        else
        {
            myAnimator.SetBool("isRunning", false);
        }
    }
}
