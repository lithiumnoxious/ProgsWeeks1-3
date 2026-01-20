using UnityEngine;

public class directonalmove : MonoBehaviour
{
    public float speed = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    //Vector2 newPos = transform.postition;
    //newPos.x += speed * Time.deltaTime;
   
    transform.position += transform.right * speed * Time.deltaTime;
    transform.position += transform.up * speed * Time.deltaTime;

    }
}
