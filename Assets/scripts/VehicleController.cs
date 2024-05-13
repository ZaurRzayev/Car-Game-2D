using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleController : MonoBehaviour
{
    public Rigidbody2D Ftire;
    public Rigidbody2D Btire;
    public Rigidbody2D Vehicle;
    public float speed;
    public float movement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        movement = Input.GetAxis("Horizontal");

    }

    // Update is called once per frame
    public void FixedUpdate()
    {
        Ftire.AddTorque(-movement * speed * Time.fixedDeltaTime);
        Btire.AddTorque(-movement * speed * Time.fixedDeltaTime);
        Vehicle.AddTorque(-movement * speed * Time.fixedDeltaTime);
    }
}
