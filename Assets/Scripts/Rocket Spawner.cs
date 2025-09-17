using System.Net.Sockets;
using UnityEngine;

public class RocketSpawner : MonoBehaviour
{
    public GameObject[] Rocket;
    
    public float SpawnInterval = 2f;
    public int RocketCount = 4;
    public int maxRockets = 8;
    private float timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= SpawnInterval)
        {
            SpawnRockets();
            timer = 0f;
        }
    }
    void SpawnRockets()
    {
        float angleStep = 360f / RocketCount;

        for (int i = 0; i < RocketCount; i++)
        {
            float angle = angleStep * i * Mathf.Deg2Rad;
            Vector2 dir = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));

            GameObject selectedRocket = Rocket[Random.Range(0, Rocket.Length)];

            GameObject rocket = Instantiate(selectedRocket, transform.position, Quaternion.identity);
            rocket.GetComponent<RocketMovement>().SetDirection(dir);
        }
    }

    public void IncreaseRocketCount()
    {
        if (RocketCount < maxRockets)
        {
            RocketCount++;
        }
    }
}