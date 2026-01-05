using UnityEngine;

namespace PrivateAPIBridge;

/// <summary>Provides extensions for <see cref="PhysicsScene"/>.</summary>
public static class PhysicsSceneExtensions
{
    extension(PhysicsScene)
    {
        // These extensions exist to bypass validation and/or normalization of input in high-performance scenarios.

        public static bool Internal_Raycast(PhysicsScene physicsScene, Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
        {
            return PhysicsScene.Internal_Raycast(physicsScene, ray, maxDistance, ref hit, layerMask, queryTriggerInteraction);
        }

        public static int Internal_RaycastNonAlloc(PhysicsScene physicsScene, Ray ray, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
        {
            return PhysicsScene.Internal_RaycastNonAlloc(physicsScene, ray, raycastHits, maxDistance, mask, queryTriggerInteraction);
        }
    }
}
