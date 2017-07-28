using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StationController : MonoBehaviour
{
    public GameObject explosion;
    public Color[] colors;
    public Renderer lamp;

    public int winScore, loseScore;

    private GameController gameController;
    private StationStates state;

    public StationStates State
    {
        get { return state; }
        set
        {
            int numberOfState = (int)value;
            if (numberOfState  > 0)
            {
                state = value;
                //lamp.material.color = colors[numberOfState];
                lamp.material.SetColor("_EmissionColor", colors[numberOfState]);
            }
            else
            {
                DestroyYourself();
            }
        }
    }

    private void Start()
    {
        state = StationStates.normal;
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    private void DestroyYourself()
    {
        if (explosion != null)
            Instantiate(explosion, transform.position, Quaternion.identity);

        gameController.AddScore(-loseScore);

        Destroy(gameObject);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Boundary"))
        {
            gameController.AddScore(winScore);
        }
    }

}
