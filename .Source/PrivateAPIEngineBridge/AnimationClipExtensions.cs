using UnityEngine;

namespace PrivateAPIBridge;

/// <summary>Provides extensions for <see cref="AnimationClip"/>.</summary>
public static class AnimationClipExtensions
{
    extension(AnimationClip @this)
    {
        public float startTime => @this.startTime;

        public float stopTime => @this.stopTime;

        public bool hasRootMotion => @this.hasRootMotion;
    }
}
