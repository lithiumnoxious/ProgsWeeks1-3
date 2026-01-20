using UnityEngine;
using UnityEngine.InputSystem;

public class spritechange : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PickRandomColour();
    }

    // Update is called once per frame
    void Update()
    {

        //if ( Keyboard.current.anyKey.wasPressedThisFrame== true)
        // {
        //     PickRandomColour();
        // }


        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        if (spriteRenderer.bounds.Contains(mousePos) == true) 
        {
            spriteRenderer.color = col;
        }

        else {
            spriteRenderer.color = Color.white;
        }
    
    }
    void PickRandomColour()
    {
        spriteRenderer.color = Random.ColorHSV();
        
    }
}
