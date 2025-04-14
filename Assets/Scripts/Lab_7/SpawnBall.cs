using System.Collections;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    [SerializeField] private GameObject ballPrefab;

    float x, y;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnCoroutine());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator SpawnCoroutine()
    {
        while (true)
        {
            SpawnRandomPrefab();
            yield return new WaitForSeconds(2);
        }
    }
    void SpawnRandomPrefab()
    {
        x = Random.Range(-8.0f, 8.0f);
        y = Random.Range(-4.0f, 4.0f);
        Vector3 spawnPosition = new Vector3(x, y, 0);
        GameObject ball = Instantiate(ballPrefab, spawnPosition, Quaternion.identity);
        ball.GetComponent<SpriteRenderer>().color = new Color(Random.value, Random.value, Random.value, 1.0f);
        Destroy(ball, 5f);
    }
}
