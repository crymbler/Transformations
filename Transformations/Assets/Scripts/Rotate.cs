using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float _turnSpeed;

    private void Update()
    {
        transform.Rotate(Vector3.down, _turnSpeed * Time.deltaTime);
    }
}
