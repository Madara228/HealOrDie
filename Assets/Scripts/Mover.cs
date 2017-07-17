using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed;
    private Rigidbody myBody;

	void Start ()
    {
        myBody = GetComponent<Rigidbody>();
        myBody.velocity = transform.forward * speed;

	}
	
}
