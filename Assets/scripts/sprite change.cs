using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class spritechange : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;
    public Sprite mysprite;

    public List<Sprite> Barrels;
 
    public int randomNum;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        //PickRandomColour();
        PickRandomSprite();
    }

    // Update is called once per frame
    void Update()
    {

        if (Keyboard.current.anyKey.wasPressedThisFrame == true)
        {
           // PickRandomColour();
            
        }


        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        if (spriteRenderer.bounds.Contains(mousePos) == true) 
        {
            spriteRenderer.color = col;
            PickRandomSprite();
        }

        else {
            //spriteRenderer.color = Color.white;
            
        }

       if ( Mouse.current.leftButton.wasPressedThisFrame&&Barrels.Count >1)
        {
            Barrels.RemoveAt(0);
        }

    
    }
    void PickRandomColour()
    {
        spriteRenderer.color = Random.ColorHSV();
        
    }

    void PickRandomSprite()
    {
        //spriteRenderer.sprite = mysprite;
        randomNum = Random.Range(0, Barrels.Count);
        spriteRenderer.sprite = Barrels[randomNum];

    }
}
