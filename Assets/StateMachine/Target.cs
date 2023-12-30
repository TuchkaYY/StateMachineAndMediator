using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [field: SerializeField] public TargetType TargetType { get; private set; }
}
