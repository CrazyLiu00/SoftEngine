using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class BundleTest : MonoBehaviour
{
    [MenuItem("Tools/BuildTest")]
    public static void BuildBunldeTest()
    {

        BuildPipeline.BuildAssetBundles(Application.streamingAssetsPath
            , BuildAssetBundleOptions.ChunkBasedCompression, BuildTarget.StandaloneOSX);
    }
}
