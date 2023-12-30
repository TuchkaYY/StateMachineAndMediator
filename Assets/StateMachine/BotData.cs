using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotData
{
    private float _energy;

    public float Energy
    {
        get
        {
            return _energy;
        }
        set
        {
            if (value >= 0)
                _energy = value;
        }
    }
}
