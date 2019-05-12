using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SoftEngine
{
    public class SystemPath
    {
        //编辑器资源路径
        public static string baseAppEditorPath = Application.dataPath;
        //Res路径
        public static string appResEditorPath = baseAppEditorPath + "/Res";

        //streamingAssets根目录
        public static string baseLocalResPath = Application.streamingAssetsPath;

    }
}

