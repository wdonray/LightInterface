using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowLight : ILightState
{
    float timer = 0f;
    private readonly LightFSM light;
    public GameObject yLight;

    public YellowLight(LightFSM l)
    {
        light = l;
    }
    public void UpdateState()
    {
        yLight.GetComponent<Renderer>().material.color = Color.yellow;
        light.currentState = light.yellowLight;
        timer += Time.deltaTime;
        if (timer >= 3)
            ToRed();
    }
    public void ToGreen()
    {
        Debug.Log("Red -> Green?");
    }
    public void ToRed()
    {
        light.currentState = light.redLight;
        timer = 0f;
        yLight.GetComponent<Renderer>().material.color = Color.white;
    }
    public void ToYellow()
    {
        Debug.Log("Same State?");
    }
}
