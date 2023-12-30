using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToBad : MoveToTargetState
{
    public MoveToBad(IStateSwitcher stateSwitcher, Bot bot) : base(stateSwitcher, bot)
    {
        CurrentTarget = bot.TargetPoints.GetTarget(TargetType.Bed);
    }

    public override void Update()
    {
        base.Update();

        if (IsTarget)
            StateSwitcher.SwitchState<SleepState>();
    }
}
