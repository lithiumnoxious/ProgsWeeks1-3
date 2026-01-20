using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public bool leftmov = false;
    public bool rightmov = false;
    public float speed = 1;
    public float posX;

    Vector2 bottomleft;
    Vector2 topright;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bottomleft = Camera.main.ScreenToWorldPoint(new Vector2(0,0));
        topright = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width,Screen.height));
    }

    // Update is called once per frame
    void Update()
    {
        leftmov = Keyboard.current.leftArrowKey.isPressed;
        rightmov = Keyboard.current.rightArrowKey.isPressed;

        if (leftmov && posX > bottomleft.x)
        {
            Vector2 newPos = transform.position;
            newPos.x -= speed * Time.deltaTime;
            transform.position = newPos;
            posX = newPos.x;
        }
        if (rightmov && posX < topright.x)
        {
            Vector2 newPos = transform.position;
            newPos.x += speed * Time.deltaTime;
            transform.position = newPos;
            posX = newPos.x;
        }

    }
}
