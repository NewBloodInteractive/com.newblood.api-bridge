using System;
using UnityEngine.Rendering;

namespace PrivateAPIBridge;

/// <summary>Provides extensions for <see cref="GraphicsTexture"/>.</summary>
public static class GraphicsTextureExtensions
{
    extension(GraphicsTexture @this)
    {
        /// <summary>Gets a pointer to the underlying native object.</summary>
        public IntPtr GetPtr()
        {
            return @this.m_Ptr;
        }
    }
}
