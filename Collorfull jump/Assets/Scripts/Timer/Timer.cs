using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] float time;
    [SerializeField] TextMeshProUGUI text;

    public float timeRemaining
    { get { return time; } }

    private void Start()
    {
        StartCoroutine(TimeCountDown());
    }

    IEnumerator TimeCountDown()
    {
        while(time > 0)
        {
            yield return new WaitForSeconds(1f);
            time -= 1f;
            text.text = "Time Remaining = " + time.ToString();
        }    
    }
}
