
using UnityEngine;
using System.Collections;

public class CopyCameraPosition : MonoBehaviour
{
    public Transform target;
    private Vector3 offset;
    void Start()
    {
        offset = transform.position - target.position;
    }

    void LateUpdate()
    {
        transform.position = target.position + offset;
    }
}

