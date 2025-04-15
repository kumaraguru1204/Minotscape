using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour
{
    private Respawner gameController;
    public Transform respawnPoint;
    Collider2D coll;

    SpriteRenderer spriteRenderer;
    public Sprite passive, active;
    private void Awake()
    {
        gameController = GameObject.FindGameObjectWithTag("Player").GetComponent<Respawner>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        coll = GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameController.UpdateCheckpoint(respawnPoint.position);
            spriteRenderer.sprite = active;
            coll.enabled = false;
        }
    }
}
