﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateHealthBar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameState.Instance.UpdateHealthBar();        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
