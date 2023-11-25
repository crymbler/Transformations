using UnityEngine;

public class MovingForward : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector3 _direction;
    private int _xDirection = 0;
    private int _yDirection = 0;
    private int _zDirection = 1;

    private void Awake()
    {
        _direction = new Vector3(_xDirection, _yDirection, _zDirection);
    }

    private void Update()
    {
        transform.Translate(_direction * _speed * Time.deltaTime);
    }
}
