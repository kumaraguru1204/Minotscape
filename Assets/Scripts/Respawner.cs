using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawner : MonoBehaviour
{
    Vector2 checkpointPos;
    Rigidbody2D playerRb;
    private void Start()
    {
        checkpointPos = transform.position;
        playerRb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Respawner"))
        {
            Die();
        }
    }

    public void UpdateCheckpoint(Vector2 pos)
    {
        checkpointPos = pos;
    }
    
    void Die()
    {
        StartCoroutine(Respawn(0.1f));
    }

    IEnumerator Respawn(float duration)
    {
        yield return new WaitForSeconds(duration);
        transform.position = checkpointPos;
    }

    }
