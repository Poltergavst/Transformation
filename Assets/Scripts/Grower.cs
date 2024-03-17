using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grower : MonoBehaviour
{
    [SerializeField][Range(0, 10)] private float _speed;

    private void Update()
    {
        transform.localScale += _speed * Time.deltaTime * Vector3.one; 
    }
}
