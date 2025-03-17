using UnityEngine;

public class ChickenController : MonoBehaviour
{
    [SerializeField] private GameObject eggPrefab;
    [SerializeField] float timeSpawn;
    float timeStart = 0;
    float TimeRandom;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TimeRandom = Random.Range(1, 10);
    }

    // Update is called once per frame
    void Update()
    {
        timeStart += Time.deltaTime;
        if (timeStart >= TimeRandom)
        {
            Vector3 pos = transform.position;
            pos.y -= 1;
            Instantiate(eggPrefab, pos, Quaternion.identity);
            TimeRandom = Random.Range(6, 15);
            timeStart = timeSpawn;
        }
    }
}
