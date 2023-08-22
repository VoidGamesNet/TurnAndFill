using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UPin : MonoBehaviour
{
    [SerializeField] private Transform _rotateableObject;

    public bool FlatPin;

    [SerializeField] private float _maxYPos;
    [SerializeField] private float _minYPos;
    public Vector3 target;

    public bool _uping;
    public bool _lefting;

    [SerializeField] private GameObject normalColl;
    [SerializeField] private GameObject bigColl;

    private void Update()
    {
        target.x = 0;
        _rotateableObject.localPosition = target;
    }

    public void OnSwipeRight()
    {


    }

    public void OnSwipeLeft()
    {

    }

    public void OnSwipeUp()
    {
        if (!_uping)
        {

            target.y += Time.deltaTime * 10f;

            if (target.y > _minYPos && target.y < _maxYPos)
            {

            }
            else
            {
                target.y = Mathf.Clamp(target.y, _minYPos, _maxYPos);
            }

        }
    }

    public void OnSwipeDown()
    {
        if (!_uping)
        {
            target.y -= Time.deltaTime * 10f;

            if (target.y > _minYPos && target.y < _maxYPos)
            {

            }
            else
            {
                target.y = Mathf.Clamp(target.y, _minYPos, _maxYPos);
            }

        }
    }

    public void OnSelect()
    {
        OpenBigColliders();
    }

    public void OnDeselect()
    {
        CloseBigColliders();
    }

    public void OpenBigColliders()
    {
        normalColl.SetActive(false);
        bigColl.SetActive(true);
    }

    public void CloseBigColliders()
    {
        normalColl.SetActive(true);
        bigColl.SetActive(false);
    }

}
