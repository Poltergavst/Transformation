using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class ForwardMovement : MonoBehaviour
{
    private Vector3 _startingPostion;
    private Vector3 _endingPostion;
    private float _distance = 2f;
    private float _speed = 3f;

    private void Start()
    {
        _startingPostion = transform.position;
        _endingPostion = new Vector3(_startingPostion.x, _startingPostion.y, _startingPostion.z + _distance);
    }

    void Update()
    {
        if ( transform.position != _endingPostion )
        {
            transform.position = Vector3.MoveTowards(transform.position, _endingPostion, _speed * Time.deltaTime);
        }
        else 
        {
            _endingPostion = _startingPostion;
            _startingPostion = transform.position;
        }
    }
}
