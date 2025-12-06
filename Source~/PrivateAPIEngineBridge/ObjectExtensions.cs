using System;
using Object = UnityEngine.Object;

namespace PrivateAPIBridge;

/// <summary>Provides extensions for <see cref="Object"/>.</summary>
public static class ObjectExtensions
{
    extension(Object @this)
    {
        public IntPtr GetCachedPtr()
        {
            return @this.GetCachedPtr();
        }

        public static bool CurrentThreadIsMainThread()
        {
            return Object.CurrentThreadIsMainThread();
        }
    }
}
