using UnityEngine;

public class RocketMovement : MonoBehaviour
{
    public float speed = 8f;
    private Vector2 direction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void SetDirection(Vector2 dir)
    {
        direction = dir.normalized;
    }
    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3)(direction * speed * Time.deltaTime);
    }
}
