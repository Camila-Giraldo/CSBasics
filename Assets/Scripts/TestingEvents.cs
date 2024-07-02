using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingEvents : MonoBehaviour
{
    // Creating an event
    public event EventHandler OnSpacePressed;
    // Start is called before the first frame update
    void Start()
    {
        // Accesing the event in the same class
        // OnSpacePressed += Testing_OnSpacePressed;
    }

    // Subscribe to the event in the same classe
    /* private void Testing_OnSpacePressed(object sender, EventArgs e)
    {
         Debug.Log("Space pressed");
     } */

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // space pressed!
            // A way to check if there are any subscribers to the event and invoke it

            /* 
            if (OnSpacePressed != null){
                OnSpacePressed(this, EventArgs.Empty);
            } 
            */

            // Other way to check if there are any subscribers to the event and invoke it
            OnSpacePressed?.Invoke(this, EventArgs.Empty);
        }
    }
}
