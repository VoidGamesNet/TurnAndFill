using UnityEngine;

public class DuzPinCollider : MonoBehaviour, ISelectable
{
    public DuzPin duzPin;
    public void OnDeselect()
    {
        duzPin.OnDeselect();
    }

    public void OnSelect()
    {
        duzPin.OnSelect();
    }

    public void OnSwipeDown()
    {
        duzPin.OnSwipeDown();
    }

    public void OnSwipeLeft()
    {
        duzPin.OnSwipeLeft();
    }

    public void OnSwipeRight()
    {
        duzPin.OnSwipeRight();
    }

    public void OnSwipeUp()
    {
        duzPin.OnSwipeUp();
    }
}
