using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBeam : MonoBehaviour
{

    public Rigidbody2D beam;

    public float moveSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        beam = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        beam.velocity = new Vector2(0, 1) * moveSpeed;
        if (transform.position.y > 7.4)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
