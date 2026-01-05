using UnityEngine;

namespace PrivateAPIBridge;

/// <summary>Provides extensions for <see cref="Renderer"/>.</summary>
public static class RendererExtensions
{
    extension(Renderer @this)
    {
        /// <summary>Gets the number of materials on the renderer.</summary>
        public int GetMaterialCount()
        {
            return @this.GetMaterialCount();
        }
    }
}
