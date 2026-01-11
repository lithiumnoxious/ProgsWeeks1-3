using Unity.VisualScripting;
using UnityEditor.Tilemaps;
using UnityEngine;

public class firstScript : MonoBehaviour
{
    public float speed = 0.1f;
    public bool areYouOkay = false;
    Vector2 bottomleft;
    Vector2 topRight;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bottomleft = Camera.main.ScreenToWorldPoint(new Vector2(0,0));
        topRight = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width,Screen.height));

        //speed = Random.Range(0.01f, 0.5f);
        // transform.position = (vector2) transform.position + Random.insideUnitCircle * 2;
        if (areYouOkay == true)
        {
            transform.position = Random.insideUnitCircle * Random.Range(0.1f, 5f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos = transform.position;
        newPos.x += speed * Time.deltaTime;

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
        if (screenPos.x > Screen.width)
        {
            newPos = transform.position;
            newPos.x = topRight.x;
            transform.position = newPos;

            speed = speed * -1;

        }
        transform.position = newPos;
    }
}
