using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISelectable
{
    public void OnSwipeRight();    
    public void OnSwipeLeft();    
    public void OnSwipeUp();    
    public void OnSwipeDown();
    public void OnSelect();
    public void OnDeselect();
}
