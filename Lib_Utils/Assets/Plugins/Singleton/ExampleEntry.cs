using System;
using System.IO;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.Networking;

namespace Engine
{
    [DefaultExecutionOrder(-1)] // 动态设置脚本执行顺序
    public sealed class ExampleEntry : MonoSingleton<ExampleEntry>
    {
    }
}