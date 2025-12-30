namespace UnityEngine;

public sealed class AnimationClip : Motion
{
    public extern float startTime { get; }

    public extern float stopTime { get; }

    public extern bool hasRootMotion { get; }
}
