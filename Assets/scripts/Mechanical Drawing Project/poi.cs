using UnityEngine;
using UnityEngine.InputSystem;

public class poi : MonoBehaviour
{
    public float posX;
    public float posY;
    public float speed = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //read placement of mouse
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        //Moves the X position
        if (mousePos.x > posX)
        {
            Vector2 newPos = transform.position;
            newPos.x += speed * Time.deltaTime;
            transform.position = newPos;
            posX = newPos.x;
        }
        else
        {
            Vector2 newPos = transform.position;
            newPos.x -= speed * Time.deltaTime;
            transform.position = newPos;
            posX = newPos.x;
        }
        if (mousePos.y > posY)
        {
            Vector2 newPos = transform.position;
            newPos.y += speed * Time.deltaTime;
            transform.position = newPos;
            posY = newPos.y;
        }
        else
        {
            Vector2 newPos = transform.position;
            newPos.y -= speed * Time.deltaTime;
            transform.position = newPos;
            posY = newPos.y;
        }

        if (transform.position.x >= 9)
        {
            transform.position = new Vector2(9, posY);
        }
        if (transform.position.x <= -9)
        {
            transform.position = new Vector2(-9, posY);
        }
        if (transform.position.y >= 4)
        {
            transform.position = new Vector2(posX, 4);
        }
        if (transform.position.y <= -4)
        {
            transform.position = new Vector2(posX, -4);
        }
    }
}
