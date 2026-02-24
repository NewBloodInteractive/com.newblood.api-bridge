using UnityEngine;
using UnityEngine.AI;

namespace PrivateAPIBridge;

/// <summary>Provides extensions for <see cref="NavMesh"/>.</summary>
public static class NavMeshExtensions
{
    extension(NavMesh)
    {
        /// <summary>Returns an existing entry of NavMesh build settings by its ordered index.</summary>
        public static void GetSettingsByIndex_Injected(int index, out NavMeshBuildSettings ret) => NavMesh.GetSettingsByIndex_Injected(index, out ret);

        /// <summary>Adds a link to the NavMesh. The link is described by the NavMeshLinkData struct.</summary>
        public static int AddLinkInternal_Injected(ref NavMeshLinkData link, ref Vector3 position, ref Quaternion rotation) => NavMesh.AddLinkInternal_Injected(ref link, ref position, ref rotation);
    }
}
