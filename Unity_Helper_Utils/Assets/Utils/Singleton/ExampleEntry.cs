using System;
using System.IO;
using UnityEngine;

namespace Engine
{
    [DefaultExecutionOrder(-1)] // 动态设置脚本执行顺序
    public sealed class ExampleEntry : MonoSingleton<ExampleEntry>
    {
    }
}