namespace UnityEngine;

public sealed class AnimationClip : Motion
{
    public extern float startTime { get; }

    public extern float stopTime { get; }

    public bool hasRootMotion { get; }
}
