using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayMediator
{
    private Level _level;
    private Player _player;
    private DefeatPanel _defeatPanel;

    public GameplayMediator(Level level, Player player, DefeatPanel defeatPanel)
    {
        _level = level;
        _player = player;
        _player.Inizialize(this);

        _defeatPanel = defeatPanel;
        _defeatPanel.onRestart += Restart;
    }

    public float GetDamage()
    {
        return _player.GetDamage();
    }

    public int LevelUp()
    {
        return _player.LevelUp();
    }

    public float Heal()
    {
        return _player.Heal();
    }

    public void GameOver()
    {
        _defeatPanel.Show();
        _level.HideButtons();
    }

    public void Restart()
    {
        _level.ShowButtons();
        _player.Reset();
        _level.ResetUI(_player.PlayerData.Level, _player.PlayerData.Health);
        _defeatPanel.Hide();
    }
}
