public abstract class IState
{
    protected readonly IStateSwitcher StateSwitcher;
    protected readonly Bot Bot;

    public IState(IStateSwitcher stateSwitcher, Bot bot)
    {
        StateSwitcher = stateSwitcher;
        Bot = bot;
    }

    public abstract void Enter();
    public abstract void Update();
    public abstract void Exit();
}
