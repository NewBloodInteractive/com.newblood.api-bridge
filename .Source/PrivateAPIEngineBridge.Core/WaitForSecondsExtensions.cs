using UnityEngine;

namespace PrivateAPIBridge;

/// <summary>Provides extensions for <see cref="WaitForSeconds"/>.</summary>
public static class WaitForSecondsExtensions
{
    extension(WaitForSeconds @this)
    {
        /// <summary>Gets the amount of time in seconds that execution will be delayed for.</summary>
        public float GetSeconds()
        {
            return @this.m_Seconds;
        }
    }
}
