﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour {

    [Header("Set in Inspector")]

    public static float bottomY = -20f;

    void Update() {

        if (transform.position.y < bottomY)
        {                                // a
            Destroy(this.gameObject);

            // Get a reference to the ApplePicker component of Main Camera
            ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();   // b
            // Call the public AppleDestroyed() method of apScript
            apScript.AppleDestroyed();                                      // c
        }
    }
}
