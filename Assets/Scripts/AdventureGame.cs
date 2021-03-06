﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

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
        ManageState();
    }

    private void ManageState()
    {
        var nextStates = state.GetNextState();

        if (state = startingState)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                Debug.Log("next state = " + nextStates[0]);
                state = nextStates[0];
                textComponent.text = state.GetStateStory();
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                Debug.Log("next state = " + nextStates[0]);
                state = nextStates[0];
                textComponent.text = state.GetStateStory();
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                Debug.Log("next state = " + nextStates[1]);
                state = nextStates[1];
                textComponent.text = state.GetStateStory();
            }
        }
    }
}
