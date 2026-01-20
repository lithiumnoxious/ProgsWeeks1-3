using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class pointed : MonoBehaviour
{
    public Boolean islookaway = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (islookaway)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
            Vector2 direction = mousePos - (Vector2)transform.position;
            transform.up = direction;
        }
        else
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
            Vector2 direction = (Vector2)transform.position - mousePos;
            transform.up = direction;
        }
    }
        
}
