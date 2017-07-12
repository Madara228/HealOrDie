using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float tilt;

    private Rigidbody myBody;
   

	void Start ()
    {
        myBody = GetComponent<Rigidbody>();
	}

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
        myBody.velocity = movement * speed;
        myBody.rotation = Quaternion.Euler(0, 0, -tilt * myBody.velocity.x);
    }

}
