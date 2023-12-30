using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BotConfig", menuName = "Bot/BotConfig")]
public class BotConfig : ScriptableObject
{
    [field: SerializeField] public float MaxEnergy { get; private set; }
    [field: SerializeField] public float MinEnergy { get; private set; }
    [field: SerializeField] public float Speed { get; private set; }

}
