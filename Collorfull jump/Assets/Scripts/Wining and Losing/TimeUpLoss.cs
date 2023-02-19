using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeUpLoss : MonoBehaviour
{
    [SerializeField] Timer timer;

    private void Update()
    {
        TimeIsUp();
    }
    void TimeIsUp()
    {
        if(timer.timeRemaining == 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
