using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneOrientation : MonoBehaviour
{
    private void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }
}
