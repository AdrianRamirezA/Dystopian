using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public Rigidbody2D enemy;

    public float moveSpeed = 20.0f;

    public bool changedDirection = false;
    // Start is called before the first frame update
    void Start()
    {
        enemy = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        enemyMovement();
    }

    public void enemyMovement()
    {
        if (changedDirection == true)
        {
            enemy.velocity = new Vector2(1, 0) * -1 * moveSpeed;
        }
        else if (changedDirection == false)
        {
            enemy.velocity = new Vector2(1, 0) * moveSpeed;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "RightBoundary")
        {
            changedDirection = true;
        }

        if (collision.gameObject.name == "LeftBoundary")
        {
            changedDirection = false;
        }
    }

}
