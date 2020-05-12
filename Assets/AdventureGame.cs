﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] State startingState;
    [SerializeField] Text textComponent;
 

    State state;

    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManagedState();
    }

    private void ManagedState()
    {
        var nextStates = state.GetNextStates();

        for (int index = 0; index < nextStates.Length; index++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                state = nextStates[0];
            }
        }

        textComponent.text = state.GetStateStory();
    }
}
