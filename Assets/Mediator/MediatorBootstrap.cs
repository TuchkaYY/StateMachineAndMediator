using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediatorBootstrap : MonoBehaviour
{
    [SerializeField] private Level _level;
    [SerializeField] private DefeatPanel _defeatPanel;

    private Player _player;
    private GameplayMediator _mediator;

    private void Awake()
    {
        PlayerData playerData = new PlayerData();
        _player = new Player(playerData);

        _mediator = new GameplayMediator(_level, _player, _defeatPanel);
        _level.Initialize(_mediator);
    }
}
