using UnityEngine;
using UnityEngine.InputSystem;

public class contrrol : MonoBehaviour
{
    public bool LeftmouseisPressed = false;
    public bool RightmouseisPressed = false;
    public bool anyKeyIspressed = false;

    public float speed = 3;
    public float rotospeed = 100;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LeftmouseisPressed = Mouse.current.leftButton.isPressed;
        RightmouseisPressed = Mouse.current.rightButton.isPressed;
        anyKeyIspressed = Keyboard.current.anyKey.isPressed;

        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Debug.Log("left button pressed");
        }
        if (Mouse.current.rightButton.wasPressedThisFrame)
        {
            Debug.Log("right button pressed");
        }
        if (Keyboard.current.anyKey.wasPressedThisFrame)
        {
            Debug.Log("anyKeyWasPressed pressed");
        }

        if(Keyboard.current.leftArrowKey.isPressed)
        {
            Vector2 newPosition = transform.position;
            newPosition.x -= speed * Time.deltaTime;
            transform.position = newPosition;
        }
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            Vector2 newPosition = transform.position;
            newPosition.x += speed * Time.deltaTime;
            transform.position = newPosition;
        }
        if (Keyboard.current.downArrowKey.isPressed)
        {
            transform.position -= transform.up * speed * Time.deltaTime;
        }
        if (Keyboard.current.upArrowKey.isPressed)
        {
            transform.position += transform.up * speed * Time.deltaTime;
        }




        if (Keyboard.current.aKey.isPressed)
        {
            Vector3 newRotation = transform.eulerAngles;
            newRotation.z += rotospeed * Time.deltaTime;
            transform.eulerAngles = newRotation;
        }
        if (Keyboard.current.dKey.isPressed)
        {
            Vector3 newRotation = transform.eulerAngles;
            newRotation.z -= rotospeed * Time.deltaTime;
            transform.eulerAngles = newRotation;
        }


        }
}
