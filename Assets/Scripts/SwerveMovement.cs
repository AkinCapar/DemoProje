using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwerveMovement : MonoBehaviour
{
    private SwervingInputSystem swervingInputSystem;
    [SerializeField] private float swerveSpeed = 0.5f;

    private void Awake()
    {
        swervingInputSystem = GetComponent<SwervingInputSystem>();
    }


    private void Update()
    {
        float swerveAmount = Time.deltaTime * swerveSpeed * swervingInputSystem.MoveFactorX;
        transform.Translate(swerveAmount, 0f, 0f);
    }
}
