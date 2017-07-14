using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float tilt;
    public Boundary boundary;
    private Rigidbody myBody;
   

	void Start ()
    {
        myBody = GetComponent<Rigidbody>();

	}

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
        myBody.velocity = movement * speed;
        myBody.position = new Vector3(
            Mathf.Clamp(transform.position.x, boundary.minX, boundary.maxX),
            transform.position.y,
            Mathf.Clamp(transform.position.z, boundary.minZ, boundary.maxZ)
            );
            
        myBody.rotation = Quaternion.Euler(0, 0, -tilt * myBody.velocity.x);
    }

}
