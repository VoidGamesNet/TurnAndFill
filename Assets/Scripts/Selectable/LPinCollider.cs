using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LPinCollider : MonoBehaviour, ISelectable
{
    public LPin lpin;
    public void OnDeselect()
    {
        lpin.OnDeselect();
    }

    public void OnSelect()
    {
        lpin.OnSelect();
    }

    public void OnSwipeDown()
    {
        lpin.OnSwipeDown();
    }

    public void OnSwipeLeft()
    {
        lpin.OnSwipeLeft();
    }

    public void OnSwipeRight()
    {
        lpin.OnSwipeRight();
    }

    public void OnSwipeUp()
    {
        lpin.OnSwipeUp();
    }
}
