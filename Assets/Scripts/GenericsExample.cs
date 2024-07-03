using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericsExample : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        CreateArray(4, 3);
        TestMultiGenerics(3, "3");

        MyClass<int> myClass = new MyClass<int>();
    }

    private T[] CreateArray<T>(T firstElement, T secondElement)
    {
        return new T[] { firstElement, secondElement };
    }

    private void TestMultiGenerics<T1, T2>(T1 t1, T2 t2)
    {
        Debug.Log(t1.GetType());
        Debug.Log(t2.GetType());
    }
}

public class MyClass<T>
{
    public T value;
}
