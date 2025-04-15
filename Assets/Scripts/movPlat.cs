using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movPlat : MonoBehaviour
{
    [SerializeField] private GameObject[] wayP;
    private int cwpInd = 0;

    [SerializeField] private float speed = 2f;

    void Update()
    {
        if(Vector2.Distance(wayP[cwpInd].transform.position, transform.position) < .1f)
        {
            cwpInd++;
            if(cwpInd >= wayP.Length)
            {
                cwpInd = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, wayP[cwpInd].transform.position, Time.deltaTime * speed);
    }
}
