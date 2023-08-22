using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UPinCollider : MonoBehaviour, ISelectable
{
    public UPin uPinCollider;
    public void OnDeselect()
    {
        uPinCollider.OnDeselect();
    }

    public void OnSelect()
    {
        uPinCollider.OnSelect();
    }

    public void OnSwipeDown()
    {
        uPinCollider.OnSwipeDown();
    }

    public void OnSwipeLeft()
    {
        uPinCollider.OnSwipeLeft();
    }

    public void OnSwipeRight()
    {
        uPinCollider.OnSwipeRight();
    }

    public void OnSwipeUp()
    {
        uPinCollider.OnSwipeUp();
    }
}
