using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 300f;
    float movement = 0f;
    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");

    }
    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //add reference to retry menu and add opposit of retry button method function
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}