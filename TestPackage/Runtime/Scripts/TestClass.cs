using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestClass : MonoBehaviour
{
    private void Awake()
    {
        Debug.LogError("Test class ok");
    }

    public static void StaticTest()
    {
        Debug.LogError("TestClass.StaticTest ok");
    }
}
