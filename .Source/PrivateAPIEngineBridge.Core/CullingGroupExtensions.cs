using System;
using UnityEngine;

namespace PrivateAPIBridge;

/// <summary>Provides extensions for <see cref="CullingGroup"/>.</summary>
public static class CullingGroupExtensions
{
    extension(CullingGroup @this)
    {
        /// <summary>Gets a pointer to the underlying native object.</summary>
        public IntPtr GetPtr()
        {
            return @this.m_Ptr;
        }
    }
}
