using System;

namespace UnityEngine;

public class Object
{
    public extern IntPtr GetCachedPtr();
    public static extern bool CurrentThreadIsMainThread();
}
