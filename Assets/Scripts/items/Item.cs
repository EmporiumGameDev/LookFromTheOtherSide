using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private Collider _collider;
    [SerializeField] protected Rigidbody _rb;

    private Vector3 _offset;
    private void OnMouseDown()
    {
        _offset = gameObject.transform.position - _camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));
    }

    private void OnMouseDrag()
    {
        Vector3 newPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f);
        transform.position = _camera.ScreenToWorldPoint(newPosition) + _offset;
        _collider.enabled = false;
        if(_rb)
        {
            _rb.isKinematic = true;
        }
    }

    private void OnMouseUp()
    {
        _collider.enabled = true;
        if (_rb)
        {
            _rb.isKinematic = false;
        }
    }
}
