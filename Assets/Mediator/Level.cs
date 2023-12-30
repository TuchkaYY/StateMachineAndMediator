using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    [SerializeField] private TMP_Text _levelText;
    [SerializeField] private TMP_Text _healthText;

    [SerializeField] private Button _healButton;
    [SerializeField] private Button _levelUpButton;
    [SerializeField] private Button _damageButton;

    GameplayMediator _mediator;

    public void Initialize(GameplayMediator gameplayMediator)
    {
        _mediator = gameplayMediator;
    }

    private void OnEnable()
    {
        _healButton.onClick.AddListener(Heal);
        _damageButton.onClick.AddListener(GetDamage);
        _levelUpButton.onClick.AddListener(UpdateLevel);
    }

    private void OnDisable()
    {
        _healButton.onClick.RemoveListener(Heal);
        _damageButton.onClick.RemoveListener(GetDamage);
        _levelUpButton.onClick.RemoveListener(UpdateLevel);
    }

    public void HideButtons()
    {
        _healButton.gameObject.SetActive(false);
        _levelUpButton.gameObject.SetActive(false);
        _damageButton.gameObject.SetActive(false);
    }

    public void ShowButtons()
    {
        _healButton.gameObject.SetActive(true);
        _levelUpButton.gameObject.SetActive(true);
        _damageButton.gameObject.SetActive(true);

        UpdateLevel();
    }

    private void Heal()
    {
        float health = _mediator.Heal();
        _healthText.text = "Health" + health.ToString();
    }

    private void GetDamage()
    {
        float health = _mediator.GetDamage();
        _healthText.text = "Health" + health.ToString();
    }

    private void UpdateLevel()
    {
        int level = _mediator.LevelUp();
        _levelText.text = "Level" + level.ToString();
    }

    public void ResetUI(int level, float health)
    {
        _healthText.text = "Health" + health.ToString();
        _levelText.text = "Level" + level.ToString();
    }
}
