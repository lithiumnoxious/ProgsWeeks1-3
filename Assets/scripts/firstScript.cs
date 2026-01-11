using UnityEditor.Tilemaps;
using UnityEngine;

public class firstScript : MonoBehaviour
{
    public float speed = 0.01f;
    public bool areYouOkay = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
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
        newPos.x += speed;
        transform.position = newPos;
        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPos.x < 0 || screenPos.x > Screen.width)
        {
            speed = speed * -1;

        }


    }
}
