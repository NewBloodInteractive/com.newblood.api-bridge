using System;
using UnityEngine;

namespace PrivateAPIBridge;

/// <summary>Provides extensions for <see cref="Coroutine"/>.</summary>
public static class CoroutineExtensions
{
    extension(Coroutine @this)
    {
        /// <summary>Gets a pointer to the underlying native object.</summary>
        public IntPtr GetPtr()
        {
            return @this.m_Ptr;
        }
    }
}
