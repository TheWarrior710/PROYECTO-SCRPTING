using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AlarmManager : MonoBehaviour
{
    public TMP_InputField messageInput;
    public TMP_InputField timeInput;
    public GameObject reminderPanel;
    public TextMeshProUGUI reminderText;

    private AudioSource audioSource;

    private List<Coroutine> activeAlarms = new List<Coroutine>();

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    public void AddAlarm()
    {
        if (string.IsNullOrWhiteSpace(messageInput.text) || string.IsNullOrWhiteSpace(timeInput.text))
            return;

        if (float.TryParse(timeInput.text, out float seconds))
        {
            Coroutine newAlarm = StartCoroutine(AlarmCountdown(seconds, messageInput.text));
            activeAlarms.Add(newAlarm);
        }
    }

    IEnumerator AlarmCountdown(float delay, string message)
    {
        yield return new WaitForSeconds(delay);
        reminderText.text = $"[RELOJ] {message}";
        audioSource.Play();
        reminderPanel.SetActive(true);
    }

    public void CloseReminder()
    {
        reminderPanel.SetActive(false);
    }
}

