using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    public float moveSpeed = 15.0f;
    public Rigidbody2D ship;


    // Start is called before the first frame update
    void Start()
    {
        ship = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveShip();
    }

    public void MoveShip()
    {
        ship.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * moveSpeed;
    }
}
