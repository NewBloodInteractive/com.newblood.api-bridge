using System;
using UnityEngine;

namespace PrivateAPIBridge;

/// <summary>Provides extensions for <see cref="AnimationCurve"/>.</summary>
public static class AnimationCurveExtensions
{
    extension(AnimationCurve @this)
    {
        /// <summary>Gets a pointer to the underlying native object.</summary>
        public IntPtr GetPtr()
        {
            return @this.m_Ptr;
        }
    }
}
