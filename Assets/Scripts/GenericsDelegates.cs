using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericsDelegates : MonoBehaviour
{
    /* Builtin delegate: Action
    It's a type of delegate that returns void. Can have up to 16 parameters
    of any type. It's a generic delegate.
    */
    private Action actionDelegate;
    private Action<int, float> actionIntFloatTest;

    /* Builtin delegate: Func
    It's a type of delegate that returns a value. Can have up to 16 parameters
    */
    // Func with no parameters and return type
    private Func<bool> testFunc;

    // Func with one parameter and return type
    private Func<int, bool> testIntBoolFunc;
    private void Start()
    {
        actionIntFloatTest = (int i, float f) => { Debug.Log("Action with int and float called"); };
        testFunc = () => { return true; };
        testIntBoolFunc = (int i) => { return i > 0; };

        actionIntFloatTest(5, 3.5f);
        Debug.Log("Func with no parameters: " + testFunc());
        Debug.Log("Func with return type. Parameter > 0 =  " + testIntBoolFunc(-4));
    }
}