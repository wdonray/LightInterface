using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedLight : ILightState
{
    float timer = 0f;
    private readonly LightFSM light;
    public GameObject rLight;
    public RedLight(LightFSM l)
    {
        light = l;
    }
    public void UpdateState()
    {
        rLight.GetComponent<Renderer>().material.color = Color.red;
        timer += Time.deltaTime;
        if (timer >= 6)
            ToGreen();
    }
    public void ToGreen()
    { 
        light.currentState = light.greenLight;
        timer = 0f;
        rLight.GetComponent<Renderer>().material.color = Color.white;
    }
    public void ToRed()
    {
        Debug.Log("Same State?");
    }
    public void ToYellow()
    {
        Debug.Log("Red -> Yellow?");
    }
}
