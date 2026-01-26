using UnityEngine;
using UnityEngine.InputSystem;

public class poi : MonoBehaviour
{
    public float posX;
    public float posY;
    public float speed = 30;

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
            //Vector2 newPos = transform.position;
            //newPos.x += speed * Time.deltaTime;
            //transform.position = newPos;
            //posX = newPos.x;

            for(int i=0; i<10; i++){
                Vector2 newPoses = transform.position;
                newPoses.x += speed * Time.deltaTime;
                transform.position = newPoses;
                posX = newPoses.x;

            }
            
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


    }
}
