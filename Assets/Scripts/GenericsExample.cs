using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericsExample : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        int[] intArray = CreateArray(4, 5);
        Debug.Log(intArray.Length + " " + intArray[0] + " " + intArray[1]);
        Debug.Log(intArray.GetType());

        string[] stringArray = CreateArray("asdf", "qwerty");
        Debug.Log(stringArray.Length + " " + stringArray[0] + " " + stringArray[1]);
        Debug.Log(stringArray.GetType());
    }

    private T[] CreateArray<T>(T firstElement, T secondElement)
    {
        return new T[] { firstElement, secondElement };
    }
}
