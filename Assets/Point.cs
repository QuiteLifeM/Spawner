using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    [SerializeField] Transform[] _targets;

    public Transform GetRandomTarget()
    {
        Transform target = _targets[Random.Range(0, _targets.Length)];

        return target;
    }
}
