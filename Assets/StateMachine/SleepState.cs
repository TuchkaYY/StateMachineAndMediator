using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepState : IState
{
    public SleepState(IStateSwitcher stateSwitcher, Bot bot) : base(stateSwitcher, bot) { }

    public override void Enter()
    {
        
    }

    public override void Exit()
    {
        
    }

    public override void Update()
    {
        if (Bot.BotData.Energy >= Bot.BotConfig.MaxEnergy)
            StateSwitcher.SwitchState<MoveToTargetState>();

        Bot.BotData.Energy += Time.deltaTime;
        Debug.Log("Спит");
    }
}
