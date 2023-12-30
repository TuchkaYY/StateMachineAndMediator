using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkState : IState
{
    public WorkState(IStateSwitcher stateSwitcher, Bot bot) : base(stateSwitcher, bot) { }

    public override void Enter()
    {
        Debug.Log("Взялся за работу");
    }

    public override void Exit()
    {
        Debug.Log("я устал, нужно отдохнуть");
    }

    public override void Update()
    {
        Bot.BotData.Energy -= Time.deltaTime;
        Debug.Log("Работаю");

        if (Bot.BotData.Energy <= Bot.BotConfig.MinEnergy)
        {
            StateSwitcher.SwitchState<MoveToBad>();
        }
    }
}
