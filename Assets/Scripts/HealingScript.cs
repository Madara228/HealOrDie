using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Station"))
        {
            StationController stationController = other.gameObject.GetComponent<StationController>();
            if( (int)stationController.State != System.Enum.GetNames(typeof(StationStates)).Length - 1)
            {
                stationController.State++;
            }
        }
    }

}
