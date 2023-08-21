using UnityEngine;
public enum Direction { Right, Left };

public class SelectManager : MonoBehaviour
{
    [SerializeField] private LayerMask _selectableMask;
    [SerializeField] private LayerMask _selectableBigMask;

    public static SelectManager Instance;

    public bool _isSelected;
    public Vector3 _clickedPoint;

    //Touch Veriable
    private Vector2 StartTouchPosition;
    private Vector2 PrevTouchPosition;
    private Vector2 CurrentPosition;
    private ISelectable _selectedPin;

    private void Awake()
    {
        Instance = this;
    }


    private void Update()
    {
        Swipe();
    }



    public void Swipe()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartTouchPosition = Input.mousePosition;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit, 100, _selectableMask))
            {
                if (hit.collider.TryGetComponent(out ISelectable selectedPin))
                {
                    StartTouchPosition = Input.mousePosition;
                    _isSelected = true;
                    _selectedPin = selectedPin;
                    _selectedPin.OnSelect();
                }
            }
            PrevTouchPosition = Input.mousePosition;



        }

        if (_isSelected)
        {
            CurrentPosition = Input.mousePosition;
            Vector2 Distance = CurrentPosition - PrevTouchPosition;
            RayHit();
            PrevTouchPosition = Input.mousePosition;
            if (Distance.x < -0.1f)
            {
                //_selectedPin.AdjustPinPos(Distance.x);
                _selectedPin.OnSwipeLeft();
            }

            else if (Distance.x > 0.1f)
            {
                //Debug.Log("Secili = " + Distance.x);

                //_selectedPin.AdjustPinPos(Distance.x);
                _selectedPin.OnSwipeRight();
            }
            if (Distance.y < -0.1f)
            {
                _selectedPin.OnSwipeDown();
            }
            else if (Distance.y > 0.1f)
            {
                _selectedPin.OnSwipeUp();
            }

        }

        if (Input.GetMouseButtonUp(0))
        {
            if(_selectedPin!= null)
            {
                _selectedPin.OnDeselect();
            }
            _isSelected = false;
            _selectedPin = null;
        }
    }
    public void RayHit()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit, 100, _selectableBigMask))
        {
            if (hit.collider.TryGetComponent(out ISelectable selectedPin))
            {
                StartTouchPosition = Input.mousePosition;
                _selectedPin = selectedPin;
            }
        }
        //PrevTouchPosition = Input.mousePosition;

    }
}

