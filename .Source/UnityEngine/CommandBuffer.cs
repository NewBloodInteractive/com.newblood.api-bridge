using System;

namespace UnityEngine.Rendering;

public class CommandBuffer : IDisposable
{
    public extern void Dispose();
    public extern void Internal_DrawRenderer(Renderer renderer, Material material, int submeshIndex, int shaderPass);
    public extern void Internal_DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties);
}
