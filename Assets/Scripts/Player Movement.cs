using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = Vector3.zero;

        if (Input.GetKey(KeyCode.W)) move.y += 1;
        if (Input.GetKey(KeyCode.S)) move.y -= 1;
        if (Input.GetKey(KeyCode.A)) move.x -= 1;
        if (Input.GetKey(KeyCode.D)) move.x += 1;

        transform.position += move.normalized * Speed * Time.deltaTime;
    }
}
