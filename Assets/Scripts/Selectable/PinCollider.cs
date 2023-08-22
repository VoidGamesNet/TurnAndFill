using UnityEngine;

public enum Yon { Yok ,SaatYonu, SaatYonuTersi,Sag,Sol,Ust,Alt}
public class PinCollider : MonoBehaviour, ISelectable
{
    [SerializeField] private PinAbstract PinParent;

    [SerializeField] private Yon SagUst;
    [SerializeField] private Yon SagAlt;
    [SerializeField] private Yon SolUst;
    [SerializeField] private Yon SolAlt;
    [SerializeField] private Yon Sag;
    [SerializeField] private Yon Sol;
    [SerializeField] private Yon Ust;
    [SerializeField] private Yon Alt;


    bool InputUp;
    bool InputDown;
    bool InputRight;
    bool InputLeft;

    private void Update()
    {
        //if (!PinParent.FlatPin)
        {
            if (InputRight && InputUp)
            {
                if (SagUst == Yon.SaatYonu)
                {
                    PinParent.SaatYonu();
                }
                else if (SagUst == Yon.SaatYonuTersi)
                {
                    PinParent.SaatTersYonu();
                }
            }
            else if (InputRight && InputDown)
            {
                if (SagAlt == Yon.SaatYonu)
                {
                    PinParent.SaatYonu();
                }
                else if (SagAlt == Yon.SaatYonuTersi)
                {
                    PinParent.SaatTersYonu();
                }
            }
            else if (InputLeft && InputUp)
            {
                if (SolUst == Yon.SaatYonu)
                {
                    PinParent.SaatYonu();
                }
                else if (SolUst == Yon.SaatYonuTersi)
                {
                    PinParent.SaatTersYonu();
                }
            }
            else if (InputLeft && InputDown)
            {
                if (SolAlt == Yon.SaatYonu)
                {
                    PinParent.SaatYonu();
                }
                else if (SolAlt == Yon.SaatYonuTersi)
                {
                    PinParent.SaatTersYonu();
                }
            }
            else if (InputRight)
            {
                if (Sag == Yon.SaatYonu)
                {
                    PinParent.SaatYonu();
                }
                else if (Sag == Yon.SaatYonuTersi)
                {
                    PinParent.SaatTersYonu();
                }
            }
            else if (InputLeft)
            {
                if (Sol == Yon.SaatYonu)
                {
                    PinParent.SaatYonu();
                }
                else if (Sol == Yon.SaatYonuTersi)
                {
                    PinParent.SaatTersYonu();
                }
            }
            else if (InputUp)
            {
                if (Ust == Yon.SaatYonu)
                {
                    PinParent.SaatYonu();
                }
                else if (Ust == Yon.SaatYonuTersi)
                {
                    PinParent.SaatTersYonu();
                }
            }
            else if (InputDown)
            {
                if (Alt == Yon.SaatYonu)
                {
                    PinParent.SaatYonu();
                }
                else if (Alt == Yon.SaatYonuTersi)
                {
                    PinParent.SaatTersYonu();
                }
            }
            ResetAll();
        }
        //else
        //{
        //    if (InputRight)
        //    {
        //        Debug.Log("Burda1");
        //        PinParent.RightMove();                
        //    }
        //    if (InputLeft)
        //    {
        //        Debug.Log("Burda2");
        //        PinParent.LeftMove();
        //    }
        //    if (InputUp)
        //    {
        //        Debug.Log("Burda3");
        //        PinParent.UpMove();
        //    }
        //    if (InputDown)
        //    {
        //        Debug.Log("Burda4");
        //        PinParent.DownMove();
        //    }
        //    ResetAll();
        //}
    }
    public void OnSwipeLeft()
    {
        InputLeft = true;
    }

    public void OnSwipeRight()
    {
        InputRight = true;
    }

    public void OnSwipeUp()
    {
        InputUp = true;
    }
    public void OnSwipeDown()
    {
        InputDown = true;
    }
    public void ResetAll()
    {
        InputUp = false;
        InputLeft = false;
        InputDown = false;
        InputRight = false;
    }

    public void OnSelect()
    {
        PinParent.OpenBigColliders();
    }

    public void OnDeselect()
    {
        PinParent.CloseBigColliders();
    }
}
