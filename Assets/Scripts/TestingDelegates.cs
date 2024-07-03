using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingDelegates : MonoBehaviour
{
    // Delegate declaratino with no parameters and return type
    public delegate void TestDelegate();
    // Field of type delegate declared above
    public delegate bool TestBoolDelegate(int i);
    private TestBoolDelegate testBoolDelegate;
    private TestDelegate testDelegateFunction;

    private void Start()
    {
        // Assigning the function to the delegate
        testDelegateFunction = MyDelegateFunction;
        // Delegates can be Multicast (Multidifusión)
        testDelegateFunction += SecondDelegateFunction;

        // Calling the delegate. Activates all the functions assigned to it
        //testDelegateFunction();

        // Removing a function from the delegate
        testDelegateFunction -= SecondDelegateFunction;
        //testDelegateFunction();

        testBoolDelegate = TestBoolFunction;
        //Debug.Log(testBoolDelegate(-4));

        // Anonymous function with no parameters and return type
        testDelegateFunction = delegate () { Debug.Log("Anonymous function called"); };
        //testDelegateFunction();

        // Lambda expression with no parameters and return type
        testDelegateFunction -= MyDelegateFunction;
        testDelegateFunction += () => { Debug.Log("Lambda expression called"); };
        //testDelegateFunction();

        testBoolDelegate -= TestBoolFunction;
        // Lambda expression with parameters and return type
        testBoolDelegate -= (int i) => { return i > 0; };

        // Other way to do it
        testBoolDelegate += (int i) => i > 0;
        
        Debug.Log(testBoolDelegate(-4));
    }

    // Function to be assigned to the delegate(testDelegateFunction) 
    private void MyDelegateFunction()
    {
        Debug.Log("Delegate function called");
    }

    private void SecondDelegateFunction()
    {
        Debug.Log("Second Delegate function called");
    }

    private bool TestBoolFunction(int i)
    {
        return i > 0;
    }

}