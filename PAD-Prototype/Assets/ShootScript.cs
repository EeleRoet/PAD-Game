using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{

    public Rigidbody2D playerBody;
    // public FireScript fireScript;
    public GameObject laser;
    private FireScript script;

    // Start is called before the first frame update
    void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
        script = laser.GetComponent<FireScript>();
       // fireScript = GetComponent<FireScript>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Shoot(1);
    }

    public void Shoot(int helling)
    {
        float afstand = Screen.width / 2;
        float hoogte = afstand * helling;
        float hoek = Mathf.Atan(hoogte / afstand);

        playerBody.SetRotation(hoek * Mathf.Rad2Deg + 90);


        script.Fire(helling);
    }
}
