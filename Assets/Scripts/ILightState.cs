using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ILightState
{
    void ToRed();

    void ToYellow();

    void ToGreen();

    void UpdateState();

}
