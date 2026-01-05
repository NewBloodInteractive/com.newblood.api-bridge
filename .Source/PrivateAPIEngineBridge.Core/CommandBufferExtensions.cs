using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace PrivateAPIBridge;

/// <summary>Provides extensions for <see cref="CommandBuffer"/>.</summary>
public static class CommandBufferExtensions
{
    extension(CommandBuffer @this)
    {
        /// <summary>Gets a pointer to the underlying native object.</summary>
        public IntPtr GetPtr()
        {
            return @this.m_Ptr;
        }

        // These extensions exist to bypass validation and/or normalization of input in high-performance scenarios.

        public void Internal_DrawRenderer(Renderer renderer, Material material, int submeshIndex, int shaderPass)
        {
            @this.Internal_DrawRenderer(renderer, material, submeshIndex, shaderPass);
        }

        public void Internal_DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties)
        {
            @this.Internal_DrawMesh(mesh, matrix, material, submeshIndex, shaderPass, properties);
        }
    }
}
