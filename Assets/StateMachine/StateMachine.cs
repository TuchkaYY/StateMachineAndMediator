using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class StateMachine : IStateSwitcher
{
    private List<IState> _states;
    private IState _currentState;

    public StateMachine(Bot bot)
    {
        _states = new List<IState>
        {
            new MoveToWork(this, bot),
            new MoveToBad(this, bot),
            new SleepState(this, bot),
            new WorkState(this, bot)
        };

        _currentState = _states[0];
    }

    public void SwitchState<State>() where State : IState
    {
        IState state = _states.FirstOrDefault(state => state is State);

        _currentState.Exit();
        _currentState = state;
        _currentState.Enter();
    }

    public void Update() => _currentState.Update();
}
