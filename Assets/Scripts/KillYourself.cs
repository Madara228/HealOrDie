using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillYourself : MonoBehaviour
{

    public float deathTime;

	void Start ()
    {
        Destroy(gameObject, deathTime);
	}
	

}
