using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public PlayerData PlayerData { get; private set; }
    private GameplayMediator _mediator;

    private const float _damage = 1;
    private const float _heath = 1;
    private const int _level = 1;

    public void Inizialize(GameplayMediator mediator)
    {
        _mediator = mediator;
    }

    public Player(PlayerData player)
    {
        PlayerData = player;
    }

    public float Heal()
    {
        PlayerData.Health += _heath;
        return PlayerData.Health;
    }

    public float GetDamage()
    {
        PlayerData.Health -= _damage;

        if (PlayerData.Health < 0)
            _mediator.GameOver();

        return PlayerData.Health;
    }

    public int LevelUp()
    {
        PlayerData.Level += _level;
        return PlayerData.Level;
    }

    public void Reset()
    {
        PlayerData.Level = 0;
        PlayerData.Health = 0;
    }
}
