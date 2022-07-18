using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float speed = 25f;
    Object bulletRef;
    public GameObject goli;
    
    // Start is called before the first frame update
    void Start()
    {
        //bulletRef = Prefabs.Load("Bullet");
        
    }

    // Update is called once per frame
    void Update()
    {
        float ver, hor;
        Vector2 movement;

        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");


        //movement = new Vector2(hor, ver);

        //movement = movement * speed * Time.deltaTime;

        // transform.position = movement;

        //SIMPLE PLAYER MOVEMENT
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }


        //BULLET 
        if (Input.GetKey(KeyCode.Space))
        {

        }

    }
}
