using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    private int _level;
    private float _health;

    public int Level
    {
        get
        {
            return _level;
        }
        set
        {
            _level = value;
        }
    }

    public float Health
    {
        get
        {
            return _health;
        }
        set
        {
            _health = value;
        }
    }
}
