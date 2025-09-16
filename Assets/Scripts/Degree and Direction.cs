using UnityEngine;

public class DegreeandDirection : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private float Timevalue;
    public float speed;
    public float degrees;


   
    void Start()
    {

        Timevalue += Time.deltaTime;

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector2();
    }
}
