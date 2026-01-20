using UnityEngine;
using UnityEngine.InputSystem;

public class turnpoint : MonoBehaviour
{
    public float mouseX;
    public float mouseY;
    public float speed = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        Vector2 direction = mousePos - (Vector2)transform.position;
        transform.up = direction;
        mouseX = mousePos.x;
        mouseY = mousePos.y;

        //Vector3 newRotation = transform.eulerAngles;
        //newRotation.z += speed + Time.deltaTime;
        //transform.eulerAngles = newRotation;
    }
}
