using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    State state;

    string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };

    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
        Debug.Log(days[1]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
