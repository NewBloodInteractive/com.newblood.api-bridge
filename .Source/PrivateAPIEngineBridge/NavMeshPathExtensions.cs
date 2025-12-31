using System;
using UnityEngine.AI;

namespace PrivateAPIBridge;

/// <summary>Provides extensions for <see cref="NavMeshPath"/>.</summary>
public static class NavMeshPathExtensions
{
    extension(NavMeshPath @this)
    {
        /// <summary>Gets a pointer to the underlying native object.</summary>
        public IntPtr GetPtr()
        {
            return @this.m_Ptr;
        }
    }
}
