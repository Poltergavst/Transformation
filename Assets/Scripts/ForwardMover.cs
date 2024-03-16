using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class ForwardMover : MonoBehaviour
{
    [SerializeField][Range(0, 10)] private float _speed;

    void Update()
    {
        transform.Translate(_speed * Time.deltaTime * Vector3.forward, Space.Self);
    }
}
