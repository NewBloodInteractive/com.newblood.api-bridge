using System;
using UnityEngine;

namespace PrivateAPIBridge;

/// <summary>Provides extensions for <see cref="AsyncOperation"/>.</summary>
public static class AsyncOperationExtensions
{
    extension(AsyncOperation @this)
    {
        /// <summary>Gets a pointer to the underlying native object.</summary>
        public IntPtr GetPtr()
        {
            return @this.m_Ptr;
        }
    }
}
