// Disabled until special handling for WebGL is implemented.
#if false
using System;
using UnityEngine;

namespace PrivateAPIBridge;

/// <summary>Provides extensions for <see cref="Ping"/>.</summary>
public static class PingExtensions
{
    extension(Ping @this)
    {
        /// <summary>Gets a pointer to the underlying native object.</summary>
        public IntPtr GetPtr()
        {
            return @this.m_Ptr;
        }
    }
}
#endif
