using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class grabScript : MonoBehaviour
{
    [SerializeField] private Transform GPos;
    [SerializeField] private Transform RPos;

    private float rDist;
    private GameObject grabbedObj;
    private int layerIndex;

    private void Start()
    {
        layerIndex = LayerMask.NameToLayer("Grab");
    }

    void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(RPos.position, transform.right, rDist);

        if(hitInfo.collider!=null && hitInfo.collider.gameObject.layer == layerIndex)
        {
            if(Keyboard.current.spaceKey.wasPressedThisFrame && grabbedObj == null)
            {
                grabbedObj=hitInfo.collider.gameObject;
                grabbedObj.GetComponent<Rigidbody2D>().isKinematic = true;
                grabbedObj.transform.position=GPos.position;
                grabbedObj.transform.SetParent(transform);
            }

            else if(Keyboard.current.spaceKey.wasPressedThisFrame)
            {
                grabbedObj.GetComponent<Rigidbody2D>().isKinematic = false;
                grabbedObj.transform.SetParent(null);
                grabbedObj=null;
            }
        }

        Debug.DrawRay(RPos.position, transform.right*rDist);
    }
}
