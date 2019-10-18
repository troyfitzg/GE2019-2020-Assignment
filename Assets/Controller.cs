using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Rigidbody player;

    public float Speed = 100f;
    public float force = 100f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        player.transform.Translate(0, 0, force * Time.deltaTime);

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            player.transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * Speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {

            player.transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * Speed, 0, 0);
        }

   
    }
}
