using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private Vector3 offset;
     private Camera _camera;
    Collider _collider;
    private void Start()
    {
        _camera = Camera.main;
        _collider = GetComponent<Collider>();
    }

    void OnMouseDown()
    {
        offset = gameObject.transform.position -_camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));
    }

    void OnMouseDrag()
    {
        Vector3 newPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f);
        transform.position = _camera.ScreenToWorldPoint(newPosition) + offset;
        _collider.enabled = false;
    }
    private void OnMouseUp()
    {
        _collider.enabled = true;
    }
}
