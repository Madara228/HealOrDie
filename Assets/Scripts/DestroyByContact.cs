using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {

    public int scoreValue;
    public GameObject deathParticle;
    public GameObject targetParticle;


    private GameController gameController;

    void Start()
    {
        GameObject gameControllerObject = GameObject.FindGameObjectWithTag("GameController");
        if (gameControllerObject != null)
            gameController = gameControllerObject.GetComponent<GameController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Boundary"))
        {
            return;
        }

        if (other.gameObject.CompareTag("Player"))
        {
            gameController.EndGame();
            if (targetParticle != null)
                Instantiate(targetParticle, other.transform.position, Quaternion.identity);
        }

        if (other.gameObject.CompareTag("Lazer"))
            gameController.AddScore(scoreValue);

        if (deathParticle != null)
            Instantiate(deathParticle, transform.position, Quaternion.identity);

        if (other.gameObject.CompareTag("Station"))
        {
            other.gameObject.GetComponent<StationController>().State--;
        }
        else
        {
            Destroy(other.gameObject);
        }
        
        Destroy(gameObject);
    }
}