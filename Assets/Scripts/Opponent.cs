using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Opponent : MonoBehaviour
{
    [SerializeField] GameObject target;
    public NavMeshAgent opponent;
    Animator myAnimator;
    [SerializeField] Vector3 startPoint;
    private void Start()
    {
        myAnimator = GetComponent<Animator>();
        transform.position = new Vector3(transform.position.x, 0f, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        OpponentAI();

    }

    private void OpponentAI()
    {
        Ray ray = new Ray(target.transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            opponent.SetDestination(hit.point);

            myAnimator.SetBool("isRunning", true);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            transform.position = new Vector3(startPoint.x, startPoint.y, startPoint.z);
        }

        if (collision.gameObject.tag == "FinishZone")
        {

            FindObjectOfType<SceneLoader>().ActivateLoseCanvas();
        }

    }

}
