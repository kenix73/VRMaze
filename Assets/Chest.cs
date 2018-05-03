﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour {
    public Transform chestTop;
    public Transform winAnimation;
    private bool _opening = false;
    // Use this for initialization
    
    public void OpenChest()
    {
        _opening = true;
    }
    private void Update()
    {
        Transform topTransform = chestTop.GetComponent<Transform>();

        if (_opening && topTransform.localEulerAngles.x < 358.0f)
        {
            topTransform.Rotate(Vector3.right * 20.0f * Time.deltaTime);
        }
    }
}
