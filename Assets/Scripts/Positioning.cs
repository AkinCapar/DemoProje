using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Positioning : MonoBehaviour
{
    [SerializeField] GameObject positionText;

    private void Update()
    {
        FindClosestTarget();
    }

    private void FindClosestTarget()
    {
        int position = 0;
        Player player = FindObjectOfType<Player>();
        float playerDistance = Vector3.Distance(transform.position, player.transform.position);
        Opponent[] opponents = FindObjectsOfType<Opponent>();

        foreach (Opponent opponent in opponents)
        {
            float opponentDistance = Vector3.Distance(transform.position, opponent.transform.position);
            if (playerDistance > opponentDistance)
            {
                position++;
            }
        }

        if(position == 0)
        {
            positionText.GetComponent<Text>().text = "11th";
        }

        if (position == 1)
        {
            positionText.GetComponent<Text>().text = "10th";
        }

        if (position == 2)
        {
            positionText.GetComponent<Text>().text = "9th";
        }

        if (position == 3)
        {
            positionText.GetComponent<Text>().text = "8th";
        }

        if (position == 4)
        {
            positionText.GetComponent<Text>().text = "7th";
        }

        if (position == 5)
        {
            positionText.GetComponent<Text>().text = "6th";
        }

        if (position == 6)
        {
            positionText.GetComponent<Text>().text = "5th";
        }

        if (position == 7)
        {
            positionText.GetComponent<Text>().text = "4th";
        }

        if (position == 8)
        {
            positionText.GetComponent<Text>().text = "3rd";
        }

        if (position == 9)
        {
            positionText.GetComponent<Text>().text = "2nd";
        }

        if (position == 10)
        {
            positionText.GetComponent<Text>().text = "1st";
        }
    }    
}
