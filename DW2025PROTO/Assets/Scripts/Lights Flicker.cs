using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsFlicker : MonoBehaviour
{
    Light light;
    float curIntensity;
    void Start()
    {
        curIntensity = 0.5f;
        light = gameObject.GetComponentInChildren<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        curIntensity += Random.Range(-1f, 1f) * Time.deltaTime;

        curIntensity = Mathf.Clamp(curIntensity, 0.25f, 0.75f);
        light.intensity = curIntensity;
    }
}
