using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   public float speed = 10f;
   public Rigidbody2D bullet2d;
    // Start is called before the first frame update
    void Start()
    {
        bullet2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixUpdate()
    {

        bullet2d.AddForce(new Vector2(20, 0));
        
        
        
        
    }
}
