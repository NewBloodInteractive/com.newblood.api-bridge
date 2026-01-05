using System;
using Object = UnityEngine.Object;

namespace PrivateAPIBridge;

/// <summary>Provides extensions for <see cref="Object"/>.</summary>
public static class ObjectExtensions
{
    extension(Object @this)
    {
        /// <summary>Gets a pointer to the underlying native object.</summary>
        public IntPtr GetCachedPtr()
        {
            return @this.GetCachedPtr();
        }

        /// <summary>Returns true if called from the main thread.</summary>
        public static bool CurrentThreadIsMainThread()
        {
            return Object.CurrentThreadIsMainThread();
        }

        /// <summary>Returns the offset of the <c>m_InstanceID</c> field in the C++ <c>Object</c> class.</summary>
        public static int GetOffsetOfInstanceIDInCPlusPlusObject()
        {
            return Object.GetOffsetOfInstanceIDInCPlusPlusObject();
        }
    }
}
