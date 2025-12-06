using UnityEngine;

namespace PrivateAPIBridge;

/// <summary>Provides extensions for <see cref="Renderer"/>.</summary>
public static class RendererExtensions
{
    extension(Renderer @this)
    {
        public int GetMaterialCount()
        {
            return @this.GetMaterialCount();
        }
    }
}
