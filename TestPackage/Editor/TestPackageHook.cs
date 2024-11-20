using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[InitializeOnLoad]
public static class TestPackageHook
{
    static TestPackageHook()
    {
        Debug.LogError("TestPackageHook ok ");
    }

    public static void StaticTest()
    {
        Debug.LogError("TestPackageHook.StaticTest ok");
    }
}
