using UnityEngine;
using UnityEngine.InputSystem;

public class rollover : MonoBehaviour
{
    public bool mouseIsOver = false;
    public float dis = 1;
    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //float distance = Vector2.Distance(transform.position, mousePos);
        if (Vector2.Distance(transform.position, mousePos) < dis)
        {
            mouseIsOver = true;
        }
        else 
        { 
            mouseIsOver = false;
        }
        
    }
}
