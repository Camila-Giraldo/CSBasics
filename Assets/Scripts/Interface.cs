using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interface : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MyClass myClass = new MyClass();
        TestInterface(myClass);
    }

    private void TestInterface(IMyInterface myInterface)
    {
        myInterface.TestFunction();
    }
}

public interface IMyInterface
{
    void TestFunction();
}

public class MyClass : IMyInterface
{
    public void TestFunction()
    {
        Debug.Log("MyClass.TestFunction()");
    }
}