using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveobjectL0s0 : MonoBehaviour
{
    public float speed = 10.0f;
    public GameObject car;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //car.transform.position = new Vector3(transform.position.y+ 0, transform.position.z + 20);
        //moveForward();
        //Vector3 position = new Vector3(0,0, speed); // this will create a vector with the values of the x, y, and z values
        //transform.position = position;
        transform.Translate(Vector3.forward, Space.Self);
    }
    public void moveForward()
    {
        //transform.position = new Vector3(transform.position.y+0, transform.position.z+20);
    }
}
