using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beam : MonoBehaviour
{
    public GameObject laserBeam;
    public Transform projectileSpawn;

    public float nextFire = 1.0f;
    public float currentTime = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        projectileSpawn = this.gameObject.transform;

    }

    // Update is called once per frame
    void Update()
    {
        beam();
    }

    public void beam()
    {
        currentTime += Time.deltaTime;

        if (Input.GetButton ("Jump") && currentTime > nextFire)
        {
            nextFire += currentTime;

            Instantiate (laserBeam, projectileSpawn.position, Quaternion.identity);

            nextFire -= currentTime;
            currentTime = 0.0f;
        }
    }

}
