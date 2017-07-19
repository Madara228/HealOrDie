using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour {

    public float tumble;

    private Rigidbody myBody;

    private void Start()
    {
        myBody = GetComponent<Rigidbody>();
        myBody.angularVelocity = Random.insideUnitSphere * tumble;
    }


    //   void Update () {
    //       transform.Rotate(10, 15, 15);
    //}
}
