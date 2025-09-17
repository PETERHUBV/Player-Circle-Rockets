using UnityEngine;
using System.Collections.Generic;
public class PowerUpManager : MonoBehaviour
{
    public Transform player;
    public GameObject PowerUp;
    public List<Transform> powerUps = new List<Transform>();
    public float pickupDistance = 1.0f;

    public int maxPowerUps = 5;
    public float spawnRadius = 3f;

    public RocketSpawner spawner;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawner = player.GetComponent<RocketSpawner>();
        for (int i = 0; i < maxPowerUps; i++)
        {
            SpawnPowerUpNearPlayer();
        }

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = powerUps.Count - 1; i >= 0; i--)
        {
            if (Vector3.Distance(player.position, powerUps[i].position) < pickupDistance)
            {
                spawner.IncreaseRocketCount();
                Destroy(powerUps[i].gameObject);
                powerUps.RemoveAt(i);
                SpawnPowerUpNearPlayer();
            }
        }
    }

    void SpawnPowerUpNearPlayer()
    {
        Vector2 offset = Random.insideUnitCircle * spawnRadius;
        Vector3 spawnPos = player.position + new Vector3(offset.x, offset.y, 0f);

        GameObject newPowerUp = Instantiate(PowerUp, spawnPos, Quaternion.identity);
        powerUps.Add(newPowerUp.transform);
    }
}