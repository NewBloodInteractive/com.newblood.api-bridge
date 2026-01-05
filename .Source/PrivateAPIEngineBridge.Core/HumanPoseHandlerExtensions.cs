using System;
using UnityEngine;

namespace PrivateAPIBridge;

/// <summary>Provides extensions for <see cref="HumanPoseHandler"/>.</summary>
public static class HumanPoseHandlerExtensions
{
    extension(HumanPoseHandler @this)
    {
        /// <summary>Gets a pointer to the underlying native object.</summary>
        public IntPtr GetPtr()
        {
            return @this.m_Ptr;
        }
    }
}
