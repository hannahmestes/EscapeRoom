﻿using UnityEngine;
using System.Collections.Generic;

// Written by Steve Streeting 2017
// License: CC0 Public Domain http://creativecommons.org/publicdomain/zero/1.0/

/// <summary>
/// Component which will flicker a linked light while active by changing its
/// intensity between the min and max values given. The flickering can be
/// sharp or smoothed depending on the value of the smoothing parameter.
///
/// Just activate / deactivate this component as usual to pause / resume flicker
/// </summary>
public class LightFlickerEffect : MonoBehaviour {
    [Tooltip("External light to flicker; you can leave this null if you attach script to a light")]
    public Light light;

    float intensity = 0;


    void Start() {
         if (light == null) {
            light = GetComponent<Light>();
         }
    }

    void Update() {
        if (light == null)
            return;

        // Generate random new item, calculate new average
        float newVal = Random.Range(0, 1);
        intensity = (intensity+newVal)/2;
        light.intensity = intensity;

        // Calculate new smoothed average
    }

}