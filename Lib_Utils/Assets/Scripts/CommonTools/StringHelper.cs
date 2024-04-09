using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public static class CommonHelper
{
    /// <summary>
    /// 将中文的unicode转成能识别的GBK编码
    /// 输入：\\u6839\\u8282\\u70B9
    /// 输出：根节点
    /// </summary>
    /// <param name="str">转码前的string</param>
    /// <returns>转码后的string</returns>
    public static string ConvertUnicodeToGBK(string str)
    {
        Regex reg = new Regex(@"(?i)\\[uU]([0-9a-f]{4})");
        str = reg.Replace(str, delegate (Match m) { return ((char)Convert.ToInt32(m.Groups[1].Value, 16)).ToString(); });

        return str;
    }
}
