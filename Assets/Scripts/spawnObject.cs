using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnObject : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;

    private GameManager gm;

    private float timer;

    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if(timer > 6)
        {
            Destroy(gameObject);
        }
        rb.velocity = Vector2.left * (speed + gm.speedMultiplier);
    }
}
