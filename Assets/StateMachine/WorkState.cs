using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkState : IState
{
    public WorkState(IStateSwitcher stateSwitcher, Bot bot) : base(stateSwitcher, bot) { }

    public override void Enter()
    {
        Debug.Log("������ �� ������");
    }

    public override void Exit()
    {
        Debug.Log("� �����, ����� ���������");
    }

    public override void Update()
    {
        Bot.BotData.Energy -= Time.deltaTime;
        Debug.Log("�������");

        if (Bot.BotData.Energy <= Bot.BotConfig.MinEnergy)
        {
            StateSwitcher.SwitchState<MoveToBad>();
        }
    }
}
