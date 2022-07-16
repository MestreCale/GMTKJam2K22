using System;
using UnityEngine;

[Serializable]
public struct EntityMovementProperties
{
    [SerializeField] private float speed;

    public float Speed => speed;
}