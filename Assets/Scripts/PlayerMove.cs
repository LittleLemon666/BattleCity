using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Vector3 velocity;
    float rotate_speed = 1;
    float forward_speed = 1;
    float backward_speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");

        velocity = new Vector3(0, 0, v);
        velocity = transform.TransformDirection(velocity);

        if (v > 0.1)
        {
            velocity *= forward_speed;
        }
        else if (v < -0.1)
        {
            velocity *= backward_speed;
        }

        transform.localPosition += velocity * Time.fixedDeltaTime;
        transform.Rotate(0, h * rotate_speed, 0);
    }
}
