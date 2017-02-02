using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFSM : MonoBehaviour
{
    [HideInInspector]
    public RedLight redLight;
    [HideInInspector]
    public YellowLight yellowLight;
    [HideInInspector]
    public GreenLight greenLight;
    [HideInInspector]
    public ILightState currentState;
    [HideInInspector]
    public MeshRenderer meLight;
    public Renderer rend;
    private void Awake()
    {
        redLight = new RedLight(this);
        yellowLight = new YellowLight(this);
        greenLight = new GreenLight(this);
        foreach (Transform go in GetComponentsInChildren<Transform>())
        {
            if (go.name == "Green")
                greenLight.gLight = go.gameObject;
            if (go.name == "Yellow")
                yellowLight.yLight = go.gameObject;
            if (go.name == "Red")
                redLight.rLight = go.gameObject;
        }
    }
    // Use this for initialization
    void Start()
    {
        rend = GetComponent<Renderer>();
        currentState = redLight;
    }
    // Update is called once per frame
    void Update()
    {
        rend.material.color = Color.black;
        currentState.UpdateState();
    }
}
