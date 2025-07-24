using UnityEngine;
using UnityEngine.EventSystems;

public class TouchButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public enum ButtonType 
    {
    Left, Right, Jump    
    }
    public ButtonType buttonType;
    
    public static bool isLeftPressed;
    public static bool isRightPressed;
    public static bool isJumpPressed;

    public void OnPointerDown(PointerEventData eventData)
    {
    SetButtonState(true);    
    }

    public void OnPointerUp(PointerEventData eventData)
    {
    SetButtonState(false);    
    }

    private void SetButtonState(bool state )
    {
        if (buttonType == ButtonType.Left )
        {
            isLeftPressed = state;
        } 
        else if (buttonType == ButtonType.Right)
        {
            isRightPressed = state;
        }
        else if (buttonType == ButtonType.Jump)
        {
            isJumpPressed = state;
        }
    }
}
