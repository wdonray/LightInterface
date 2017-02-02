using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenLight : ILightState
{
    float timer = 0f;
    private readonly LightFSM light;
    public GameObject gLight;

    public GreenLight(LightFSM l)
    {
        light = l;
    }
    public void UpdateState()
    {
        gLight.GetComponent<Renderer>().material.color = Color.green;
        light.currentState = light.greenLight;
        timer += Time.deltaTime;
        if (timer >= 5.5)
            ToYellow();
    }
    public void ToGreen()
    {
        Debug.Log("Same State?");
    }
    public void ToRed()
    {
        Debug.Log("Green -> Red?");
    }
    public void ToYellow()
    {
        light.currentState = light.yellowLight;
        timer = 0f;
        gLight.GetComponent<Renderer>().material.color = Color.white;
    }
}
