using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyBehaviorReal : MonoBehaviour
{
    [SerializeField] private float _velocity = 1.5f;
    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
}
