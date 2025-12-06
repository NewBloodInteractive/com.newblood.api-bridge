using UnityEngine;

namespace PrivateAPIBridge;

/// <summary>Provides extensions for <see cref="Physics"/>.</summary>
public static class PhysicsExtensions
{
    extension(Physics)
    {
        public static RaycastHit[] Internal_RaycastAll(PhysicsScene physicsScene, Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
        {
            return Physics.Internal_RaycastAll(physicsScene, ray, maxDistance, mask, queryTriggerInteraction);
        }
    }
}
