using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject platformPrefab;
    public GameObject finalPlatformPrefab;

    public int numberOfPlatforms = 100;
    public float levelWidth = 3f;
    public float minY = 0.3f;
    public float maxY = 0.8f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < numberOfPlatforms; i++)
        {
            //Vector3 spawnPosition = new Vector3();
            spawnPosition.y += Random.Range(minY, maxY); // move upward each time
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);

            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
        spawnPosition.y += 2f; // extra height
        spawnPosition.x = 0f;  // centered

        Instantiate(finalPlatformPrefab, spawnPosition, Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
