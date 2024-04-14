using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public int minutes;
    public float seconds;
    public TextMeshProUGUI timerText; // Для того, что бы добавить объект в inspector

    // Цикл обновления составляет примерно 0.01 секунды
    void Update()
    {
        seconds -= Time.deltaTime;

        // Вывод времени 
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
                // Если таймер остановился, перезагружаем текущую сцену
                int sceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(sceneIndex);
            }
        }
    }
}
