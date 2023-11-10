using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class StaminaSystem : MonoBehaviour
{
    /*[SerializeField]
    private int _maxStamina;
    private int _currentStamina;

    [SerializeField]
    private float _timeToRecharge;

    DateTime _nextStaminaTime;
    DateTime _lastStaminaTime;

    bool _recharge;

    [SerializeField]
    TMP_Text currentStaminaText;
    [SerializeField]
    TMP_Text timerText;

    TimeSpan timer;

    int id;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("currentStamina")) PlayerPrefs.SetInt("currentStamina", _maxStamina);

        Load();
        StartCoroutine(RechargeStamina());

        if (_currentStamina < _maxStamina)
        {
            timer = _nextStaminaTime - DateTime.Now;

            id = NotificationSystem.instance.DisplayNotification("Stamina recargada", "Tenes toda la stamina", AddDuration(DateTime.Now, ((_maxStamina - (_currentStamina) + 1) * _timeToRecharge + 1 + (float)timer.TotalSeconds));

        }
    }

    IEnumerator RechargeStamina()
    {
        _recharge = true;

        while (_currentStamina < _maxStamina)
        {
            DateTime currentTime = DateTime.Now;
            DateTime nextTime = _nextStaminaTime;

            bool staminaAdd = false;

            while (currentTime > nextTime)
            {
                if (_currentStamina >= _maxStamina) break;

                _currentStamina++;
                staminaAdd = true;
                UpdateStamina();

                DateTime timeToAdd = nextTime;
                if (_lastStaminaTime > nextTime) timeToAdd = _lastStaminaTime;

                nextTime = AddDuration(timeToAdd, _timeToRecharge);
            }

            if (staminaAdd)
            {
                _nextStaminaTime = nextTime;
                _lastStaminaTime = DateTime.Now;
            }

            UpdateStamina();
            UpdateTimer();
            Save();

            yield return new WaitForEndOfFrame();
        }

        _recharge = false;
    }

    DateTime AddDuration(DateTime date, float duration)
    {
        return date.AddSeconds(duration);
    }

    public void UseStamina(int staminaToUse)
    {
        if (_currentStamina - staminaToUse >= 0)
        {
            _currentStamina -= staminaToUse;
            UpdateStamina();

            NotificationSystem.instance.CancelNotification(id);

            id = NotificationSystem.instance.DisplayNotification("Stamina recargada", "Tenes toda la stamina", AddDuration(DateTime.Now, ((_maxStamina - (_currentStamina) + 1) * _timeToRecharge + 1 + (float)timer.TotalSeconds));

            if (!_recharge) _nextStaminaTime = AddDuration(DateTime.Now, _timeToRecharge);
            StartCoroutine(RechargeStamina());

            Debug.Log("Stamina Gastada");
        }

        else Debug.Log("No tengo presupuesto");
    }

    void UpdateTimer()
    {
        if (_currentStamina >= _maxStamina)
        {
            timerText.text = "Stamina Completa";
            return;
        }

        TimeSpan timer = _nextStaminaTime - DateTime.Now;

        timerText.text = timer.TotalMinutes.ToString("00") + " ; " + timer.TotalSeconds.ToString("00");
    }

    void UpdateStamina()
    {
        currentStaminaText.text = _currentStamina.ToString() + " / " + _maxStamina.ToString();
    }

    void Save()
    {
        PlayerPrefs.SetInt("currentStamina", _currentStamina);
        PlayerPrefs.SetString("nextStaminaTime", _nextStaminaTime.ToString());
        PlayerPrefs.SetString("lastStaminaTime", _lastStaminaTime.ToString());

        PlayerPrefs.Save();
    }

    void Load()
    {
        _currentStamina = PlayerPrefs.GetInt("currentStamina");

        _nextStaminaTime = DateTime.Parse(PlayerPrefs.GetString("nextStaminaTime"));
        _lastStaminaTime = DateTime.Parse(PlayerPrefs.GetString("lastStaminaTime"));
    }

    DateTime StringToDate(string date)
    {
        if (string.IsNullOrEmpty(date))
        {
            return DateTime.Now;
        }
        else
        {
            return DateTime.Parse(date);
        }
    }

    private void OnApplicationQuit()
    {
        Save();
    }

    private void OnApplicationPause(bool pause)
    {
        if (pause) Save();
    }*/
}
