using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtiPin : PinAbstract
{
    [SerializeField] private GameObject BigCollidersParent;
    [SerializeField] private GameObject NormalCollidersParent;
    [SerializeField] private Transform _rotateableObject;
    public Vector3 target;



    private void Start()
    {
        target = _rotateableObject.localPosition;
    }



    public override void OpenBigColliders()
    {
        BigCollidersParent.SetActive(true);
        NormalCollidersParent.SetActive(false);
    }
    public override void CloseBigColliders()
    {
        BigCollidersParent.SetActive(false);
        NormalCollidersParent.SetActive(true);
    }
    public override void SaatYonu()
    {
        _rotateableObject.Rotate(Vector3.right * 50, Time.deltaTime * 500f, Space.Self);
    }
    public override void SaatTersYonu()
    {
        _rotateableObject.Rotate(-Vector3.right * 50, Time.deltaTime * 500f, Space.Self);
    }
}
