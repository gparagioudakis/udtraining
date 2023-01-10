using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // public, private
    // int, float, bool, string
   
    public float speed = 2.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {

       float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // transform.Translate(Vector3.right);  kanei thn idia douleia me
        transform.Translate(new Vector3(1, 0, 0) * horizontalInput * speed * Time.deltaTime);
        transform.Translate(new Vector3(0, 1, 0) * verticalInput * speed * Time.deltaTime);

        if(transform.position.x >= 9.1f)
        {
            transform.position = new Vector3(9.1f, transform.position.y, 0);
        }
        else if(transform.position.x <= -9.1f)
        {
            transform.position = new Vector3(-9.1f, transform.position.y, 0);
        }
            
        if (transform.position.y >= 0.0f)
        {
            transform.position = new Vector3(transform.position.x, 0.0f, 0);
        }
        else if (transform.position.y <= -4.6f)
        {
            transform.position = new Vector3(transform.position.x, -4.6f, 0);
        }
               
    }
}
