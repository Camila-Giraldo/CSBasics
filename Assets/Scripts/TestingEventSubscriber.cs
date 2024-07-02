using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingEventSubscriber : MonoBehaviour
{
    // Start is called before the first frame update
    private TestingEvents testingEvents;
    private void Start()
    {
        testingEvents = GetComponent<TestingEvents>();
        // Getting reference to the TestingEvents component in Editor
        // Subscribing to the event
        testingEvents.OnSpacePressed += Testing_OnSpacePressed;
    }

    private void Testing_OnSpacePressed(object sender, EventArgs e)
    {
        Debug.Log("Space pressed from TestingEventSubscriber");
        testingEvents = GetComponent<TestingEvents>();
        // Unsubscribe to the event
        testingEvents.OnSpacePressed -= Testing_OnSpacePressed;
    }

    // Update is called once per frame
    void Update() { }
}
