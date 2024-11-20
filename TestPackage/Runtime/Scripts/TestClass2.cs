using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestClass2 : MonoBehaviour
{
    private void Awake()
    {
        Debug.LogError("Test class2 ok");
    }

    public static void StaticTest()
    {
        Debug.LogError("TestClass2.StaticTest ok");
    }
}
