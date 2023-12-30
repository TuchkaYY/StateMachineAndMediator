using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MoveToTargetState : IState
{
    protected Target CurrentTarget;

    protected bool IsTarget { get; private set; }

    public MoveToTargetState(IStateSwitcher stateSwitcher, Bot bot) : base(stateSwitcher, bot) { }

    public override void Enter()
    {

    }

    public override void Update()
    {
        Vector3 direction = GetDirection();
        Bot.transform.position += direction * Time.deltaTime * Bot.BotConfig.Speed;

        if (Bot.transform.position == CurrentTarget.gameObject.transform.position)
            IsTarget = true;
    }

    public override void Exit()
    {
        IsTarget = false;
    }

    private Vector3 GetDirection() => (CurrentTarget.gameObject.transform.position - Bot.transform.position).normalized;
}
