using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public int minutes;
    public float seconds;
    public TextMeshProUGUI timerText; // ��� ����, ��� �� �������� ������ � inspector

    // ���� ���������� ���������� �������� 0.01 �������
    void Update()
    {
        seconds -= Time.deltaTime;

        // ����� ������� 
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        if (seconds <= 0)
        {
            if (minutes > 0)
            {
                seconds += 59;

                minutes--;
            }
            else
            {
                // ���� ������ �����������, ������������� ������� �����
                int sceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(sceneIndex);
            }
        }
    }
}
