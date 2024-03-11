using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Growth : MonoBehaviour
{
    [SerializeField] [Range(0, 10)] private float _speed;
    
    private Vector3 _originalSize;
    private Vector3 _maxSize = new Vector3(1.5f, 1.5f, 1.5f);
    private bool _isShrinking = false;

    private void Start()
    {
        _originalSize = transform.localScale;
    }

    void Update()
    {
        if(_isShrinking == false)
        {
            ScaleTo(_maxSize);

            if(transform.localScale == _maxSize)
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
        Vector3 newSize = Vector3.MoveTowards(transform.localScale, goalSize, _speed * Time.deltaTime);

        transform.localScale = newSize;
    }
}
