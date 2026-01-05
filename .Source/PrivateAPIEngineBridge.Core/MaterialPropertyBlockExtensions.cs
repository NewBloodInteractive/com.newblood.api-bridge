using System;
using UnityEngine;

namespace PrivateAPIBridge;

/// <summary>Provides extensions for <see cref="MaterialPropertyBlock"/>.</summary>
public static class MaterialPropertyBlockExtensions
{
    extension(MaterialPropertyBlock @this)
    {
        /// <summary>Gets a pointer to the underlying native object.</summary>
        public IntPtr GetPtr()
        {
            return @this.m_Ptr;
        }
    }
}
