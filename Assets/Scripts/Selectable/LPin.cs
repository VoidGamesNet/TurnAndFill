using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class LPin : MonoBehaviour 
{
    [SerializeField] private Transform _rotateableObject;

    public bool FlatPin;

    [SerializeField] private float _maxZPos;
    [SerializeField] private float _minZPos;
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
        if (!_uping)
        {
            _lefting = true;

            target.z += Time.deltaTime * 10f;

            if (target.z > _minZPos && target.z < _maxZPos)
            {

            }
            else
            {
                target.z = Mathf.Clamp(target.z, _minZPos, _maxZPos);
            }
            if (target.z >= _maxZPos - 0.05f)

            {
                _lefting = false;
                //target.z = 0;
            }
        }

    }

    public void OnSwipeLeft()
    {
        if (!_uping)
        {
            _lefting = true;
            target.z -= Time.deltaTime * 10f;

            if (target.z > _minZPos && target.z < _maxZPos)
            {

            }
            else
            {
                target.z = Mathf.Clamp(target.z, _minZPos, _maxZPos);
            }
            if (target.z >= _maxZPos - 0.05f)
            {
                _lefting = false;
                //target.z = 0;
            }
        }
    }

    public void OnSwipeUp()
    {
        if (!_lefting)
        {
            target.z = 0;

            _uping = true;
            target.y += Time.deltaTime * 10f;

            if (target.y > _minYPos && target.y < _maxYPos)
            {

            }
            else
            {
                target.y = Mathf.Clamp(target.y, _minYPos, _maxYPos);
            }
            if (target.y >= _maxYPos -  0.05f)
            {
                _uping = false;
                //target.z = 0;
            }
        }
    }

    public void OnSwipeDown()
    {
        if (!_lefting)
        {
            target.z = 0;

            _uping = true; 
            target.y -= Time.deltaTime * 10f;

            if (target.y > _minYPos && target.y < _maxYPos)
            {

            }
            else
            {
                target.y = Mathf.Clamp(target.y, _minYPos, _maxYPos);
            }
            if (target.y >= _maxYPos - 0.05f)
            {
                _uping = false;
                //target.z = 0;
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
