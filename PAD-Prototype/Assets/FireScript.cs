using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScript : MonoBehaviour
{
    public Rigidbody2D laserBody;
    public GameObject laser;

    int lifetime;
    // Start is called before the first frame update
    void Start()
    {
        laserBody = GetComponent<Rigidbody2D>();
       
        laser.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        CheckTimer();
    }

   private void CheckTimer()
    {
        if( lifetime < 0)
        {
            laser.SetActive(false);
        }
        else
        {
            lifetime--;
        }
    }

    public void Fire(float helling)
    {
        laser.SetActive(true);
        lifetime = 200;

        
        float afstand = Screen.width / 2;
        float hoogte = afstand * helling;
        float hoek = Mathf.Atan(hoogte / afstand);

        laserBody.SetRotation(hoek * Mathf.Rad2Deg + 90);

    }
}
