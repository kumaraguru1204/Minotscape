using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    private float rot;
    public float RotSpeed;
    public bool cwRot;
    
    void Update()
    {
        if(cwRot == false)
        {
            rot += Time.deltaTime * RotSpeed;
        }

        else
        {
            rot += -Time.deltaTime * RotSpeed;
        }

        transform.rotation = Quaternion.Euler(0,0,rot);
    }
}
