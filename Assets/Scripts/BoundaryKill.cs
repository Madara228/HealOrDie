using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryKill : MonoBehaviour {

    void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    }
}
