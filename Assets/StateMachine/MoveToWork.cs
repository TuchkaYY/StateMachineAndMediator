using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToWork : MoveToTargetState
{
    public MoveToWork(IStateSwitcher stateSwitcher, Bot bot) : base(stateSwitcher, bot)
    {
        CurrentTarget = bot.TargetPoints.GetTarget(TargetType.Work);
    }

    public override void Update()
    {
        base.Update();

        if (IsTarget)
            StateSwitcher.SwitchState<WorkState>();
    }
}
