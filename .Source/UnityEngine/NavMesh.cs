namespace UnityEngine.AI;

public static class NavMesh
{
    public static extern void GetSettingsByIndex_Injected(int index, out NavMeshBuildSettings ret);

    public static extern int AddLinkInternal_Injected(ref NavMeshLinkData link, ref Vector3 position, ref Quaternion rotation);
}
