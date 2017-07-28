using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{
    public float spawnWait;
    public float startWait;
    public float waveWait;
    public int spawnCount;
    public Text scoreText;
    public Text endText;
    public GameObject restartButton;
    public GameObject[] spawnObjects;
    public Vector3 spawnValues;

    private int score;

    void Start()
    {
        score = 0;
        UpdateScore();
        endText.enabled = false;
        restartButton.SetActive(false);
        StartCoroutine(SpawnWaves());
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < spawnCount; i++)
            {

                GameObject spawnObject = spawnObjects[Random.Range(0, spawnObjects.Length)];
                Vector3 spawnPosition = new Vector3(
                    Random.Range(-spawnValues.x, spawnValues.x),
                    spawnValues.y,
                    spawnValues.z);
                Instantiate(spawnObject, spawnPosition, Quaternion.identity);
                
                    
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
        }
    }

    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "Очки: " + score;
    }

    public void EndGame()
    {
        endText.enabled = true;
        restartButton.SetActive(true);
    }


    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
