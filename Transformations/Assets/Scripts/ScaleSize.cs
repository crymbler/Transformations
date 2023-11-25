using UnityEngine;

public class ScaleSize : MonoBehaviour
{
    [SerializeField] private float _startSize = 1f;
    [SerializeField] private float _maxSize = 1f;

    private void Update()
    {
        transform.localScale = new Vector4(Mathf.PingPong(Time.time, _maxSize) + _startSize, transform.localScale.x, transform.localScale.y, transform.localScale.z);
    }
}
