using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickController : MonoBehaviour
{
    public Joy myStick;
    public BotonSaltar myButton;

    public Vector3 stickValue;
    public bool jumpPressed;

    void Update()
    {
        stickValue = myStick.stickValue;
        jumpPressed = myButton.jumpPressed;
    }

    public float getXValue()
    {
        return stickValue.x;
    } 
    public float getYValue()
    {
        return stickValue.y;
    }
}
