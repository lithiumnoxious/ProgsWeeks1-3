using UnityEngine;

public class bounceball : MonoBehaviour
{
    public float speed = 5;
    public float directionX;
    public float directionY;
    Vector2 bottomleft;
    Vector2 topRight;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bottomleft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
        topRight = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos = transform.position;
        newPos.x += speed + directionX * Time.deltaTime;
        newPos.y += speed + directionY * Time.deltaTime;

        //transform.position = newPos;
        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        //left
        if (screenPos.x < 0)
        {
            newPos = transform.position;
            newPos.x = bottomleft.x;
            transform.position = newPos;

            speed = speed * -1;

        }
        //right
        if (screenPos.y > Screen.height)
        {
            newPos = transform.position;
            newPos.x = topRight.x;
            transform.position = newPos;

            speed = speed * -1;

        }
        //bottom
        if (screenPos.y < 0)
        {
            newPos = transform.position;
            newPos.y = bottomleft.y;
            transform.position = newPos;

           // speed = speed * -1;
           directionY = -directionY;
        }
        //top
        if (screenPos.y > Screen.height )
        {
            newPos = transform.position;
            newPos.y = topRight.y;
            transform.position = newPos;

           // speed = speed * -1;
           directionY = -directionY;
        }






        transform.position = newPos;
    }
}
