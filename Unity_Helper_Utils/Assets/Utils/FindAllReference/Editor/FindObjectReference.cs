using System.IO;
using System;
using UnityEditor;
using System.Linq;

/// <summary>
/// 检查资源在prefab、scene中的引用，打印到Console
/// </summary>
public class FindObjectReference
{
    // 资源列表右键菜单 -> FindAllReference，输出在 Console
    [MenuItem("Assets/FindAllReference", priority = 12)]
    public static void FindObjectAllReference()
    {
        string[] selectUid = Selection.assetGUIDs;
        if (selectUid.Length > 1)
        {
            EditorMessage.MessageBox(IntPtr.Zero, "目前只支持单次查找一个物体的所有引用", "确认", 0);
            return;
        }
        string path = AssetDatabase.GUIDToAssetPath(selectUid[0]);
        if (Directory.Exists(path))
        {
            EditorMessage.MessageBox(IntPtr.Zero, "目前不支持文件夹引用的查找", "确认", 0);
            return;
        }
        else if (File.Exists(path))
        {
            if (EditorSettings.serializationMode != SerializationMode.ForceText)
                EditorSettings.serializationMode = SerializationMode.ForceText;
            string[] allPath = Directory.GetFiles("Assets", "*.*", SearchOption.AllDirectories).Where(s => s.EndsWith(".prefab") || s.EndsWith(".unity")).ToArray();

            //UnityEngine.Debug.Log($"==== 开始搜索 {Selection.activeObject.name} 的引用 ====");
            int start = 0;
            int max = allPath.Length;
            int count = 0;
            string prefix = $"==== {Selection.activeObject.name} 的引用，";
            string refs = "";
            EditorApplication.update = () => {
                string content = File.ReadAllText(allPath[start]);
                if (System.Text.RegularExpressions.Regex.IsMatch(content, selectUid[0]))
                {
                    refs += allPath[start] + "\n";
                    //UnityEngine.Debug.Log(allPath[start]);
                    count++;
                }
                start++;
                float slider = (float)start / max;
                //参数1 为标题，参数2为提示，参数3为 进度百分比 0~1 之间
                EditorUtility.DisplayProgressBar("Loading", "打印中......", slider);
                if (start >= max)
                {
                    //EditorMessage.MessageBox(IntPtr.Zero, "打印完成", "确认", 0);
                    EditorUtility.ClearProgressBar();
                    EditorApplication.update = null;
                    UnityEngine.Debug.Log(prefix + $"计数：{count} ====\n" + refs);
                }
            };
        }
    }
}