using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour
{
    private BotData _botData;
    private StateMachine _stateMachine;

    [field: SerializeField] public BotConfig BotConfig { get; private set; }
    [field: SerializeField] public TargetPoints TargetPoints { get; private set; }

    public BotData BotData => _botData;


    private void Awake()
    {
        _stateMachine = new StateMachine(this);
        _botData = new BotData();

        _botData.Energy = BotConfig.MaxEnergy;
    }

    public void Update()
    {
        _stateMachine.Update();
    }
}
