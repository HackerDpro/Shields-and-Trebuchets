using UnityEngine;
using System.Collections;

public class DayNightCycle : MonoBehaviour
{
    public float dayDuration = 60f; // 60 seconden per dag
    public Light directionalLight;
    private bool isDay = true;

    void Start()
    {
        StartCoroutine(DayCycleRoutine());
    }

    IEnumerator DayCycleRoutine()
    {
        while (true)
        {
            isDay = true;
            directionalLight.intensity = 1f;
            yield return new WaitForSeconds(dayDuration / 2);

            isDay = false;
            directionalLight.intensity = 0.3f;
            yield return new WaitForSeconds(dayDuration / 2);

            GameManager.Instance.StartNewDay();
        }
    }
}
