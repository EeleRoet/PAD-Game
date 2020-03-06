using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire_script : MonoBehaviour
{
    private int lifetime;
    private float rotation;
    private bool active;
    private Rigidbody2D laserBody;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Fire", 0f, 2f);
        active = true;
        rotation = 0f;
        laserBody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (active)
        {
            rotation++;
            laserBody.rotation = rotation;
            lifetime--;
            if( lifetime < 0 )
            {
                active = false;
            }
        }
    }

    void Fire()
    {
        active = true;
        laserBody.SetRotation( Random.Range(0f, 360));
        lifetime = 60;
    }
}
