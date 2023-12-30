using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TargetPoints : MonoBehaviour
{
    [SerializeField] private List<Target> _targets;

    public Target GetTarget(TargetType targetType)
    {
        foreach (var target in _targets)
        {
            if (target.TargetType == targetType)
                return target;
        }

        throw new ArgumentException("Type is not founded");
    }
}
