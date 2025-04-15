using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movobst : MonoBehaviour
{
    public float speed;
    Vector3 tPos;

    public GameObject ways;
    public Transform[] wayPo;
    int pInd;
    int pCou;
    int dir;

    private void Awake()
    {
        wayPo = new Transform[ways.transform.childCount];
        for(int i=0; i< ways.gameObject.transform.childCount; i++)
        {
            wayPo[i] = ways.transform.GetChild(i).gameObject.transform;
        }
    }

    private void Start()
    {
        pCou = wayPo.Length;
        pInd = 1;
        tPos = wayPo[pInd].transform.position;
    }

    private void Update()
    {
        var step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, tPos, step);

        if(transform.position == tPos)
        {
            NextPoint();
        }
    }

    void NextPoint()
    {
        if(pInd == pCou-1)
        {
            dir = -1;
        }
        
        if(pInd == 0)
        {
            dir = 1;
        }

        pInd+= dir;
        tPos = wayPo[pInd].transform.position;
    }
}
