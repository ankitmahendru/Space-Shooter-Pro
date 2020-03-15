using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 7;
    void Start()
    {
        transform.position = new Vector3(0,2,2);
       
    }

    // Update is called once per frame
    void Update()
    {
        calculateMovement();
        calculateBounds();
    }

    void calculateBounds()
    {
        float xvar = transform.position.x;
        float yvar = transform.position.y;
        transform.position = new Vector3(xvar, Mathf.Clamp(yvar, -4.6f, 4.6f), 0);
        if (xvar > 11)
        {
            transform.position = new Vector3(-11, yvar, 0);
        }
        else if (xvar < -11)
        {
            transform.position = new Vector3(11, yvar, 0);
        }
        
      
    }
    void calculateMovement() {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 dir = new Vector3(horizontalInput, verticalInput, 0);
        transform.Translate(dir * speed * Time.deltaTime);
    }
}
