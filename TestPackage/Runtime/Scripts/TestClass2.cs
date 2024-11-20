using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestClass3 : MonoBehaviour
{
    private void Awake()
    {
        Debug.LogError("Test class3 ok");
    }

    public static void StaticTest()
    {
        Debug.LogError("TestClass3.StaticTest ok");
    }
}
