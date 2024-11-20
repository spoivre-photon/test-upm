using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestClass4 : MonoBehaviour
{
    private void Awake()
    {
        Debug.LogError("Test class4 ok");
    }

    public static void StaticTest()
    {
        Debug.LogError("TestClass4.StaticTest ok");
    }
}
