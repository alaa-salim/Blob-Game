using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyJump : MonoBehaviour
{
    private Vector3 startPos;

    [SerializeField]
    private float frequency = 5f;

    [SerializeField]
    private float magnitude = 5f;

    [SerializeField]
    private float offset = 0f;


    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        transform.position = startPos + transform.up * Mathf.Sin(Time.time * frequency + offset) * magnitude;
    }
}
