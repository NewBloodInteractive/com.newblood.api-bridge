using UnityEngine;

namespace PrivateAPIBridge;

/// <summary>Provides extensions for <see cref="AnimationClip"/>.</summary>
public static class AnimationClipExtensions
{
    extension(AnimationClip @this)
    {
        /// <summary>Start time in seconds.</summary>
        public float startTime => @this.startTime;

        /// <summary>Stop time in seconds.</summary>
        public float stopTime => @this.stopTime;

        /// <summary>Returns true if the <see cref="AnimationClip"/> has root motion.</summary>
        public bool hasRootMotion => @this.hasRootMotion;
    }
}
