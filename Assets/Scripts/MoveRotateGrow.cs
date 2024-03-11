using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveRotateGrow : MonoBehaviour
{
    private Vector3 _originalSize;
    private Vector3 _maxSize = new Vector3(1.8f, 1.8f, 1.8f);

    private float _rotationSpeed = 200f;
    private float _scaleSpeed = 0.5f;
    private float _movingDistance = 3f;

    private bool _isShrinking = false;

    void Start()
    {
        _originalSize = transform.localScale;
    }

    void Update()
    {
        transform.Translate(Vector3.forward * _movingDistance * Time.deltaTime, Space.Self);

        transform.Rotate(Vector3.up * _rotationSpeed * Time.deltaTime);

        if (_isShrinking == false)
        {
            ScaleTo(_maxSize);

            if (transform.localScale == _maxSize)
            {
                _isShrinking = true;
            }
        }
        else
        {
            ScaleTo(_originalSize);

            if (transform.localScale == _originalSize)
            {
                _isShrinking = false;
            }
        }
    }

    private void ScaleTo(Vector3 goalSize)
    {
        Vector3 newSize = Vector3.MoveTowards(transform.localScale, goalSize, _scaleSpeed * Time.deltaTime);

        transform.localScale = newSize;
    }
}
