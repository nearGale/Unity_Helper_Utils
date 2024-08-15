using System;
using UnityEngine;

/// <summary>
/// Log 记录
/// TODO：
///     1 接入模块统一管理
///     2 接入LogReporter
/// </summary>
public class Logger : Singleton<Logger>
{
    private bool _logTimeInfo;
    private ELogLevel _logLevel;

    private enum ELogLevel
    {
        Log,
        Warning,
        Error,
        Assert,
        Exception,
        NoLog,
    }

    private string TimeInfo =>
        _logTimeInfo ? $"[Time:{Time.time}][Frame:{Time.frameCount}] " : string.Empty;

    private static string ColorInfo(string color, string content, string info) =>
        $"<b><color={color}>{content}[{info}]-->></color></b>";

    public void Log(string format, params object[] param)
    {
        if (ELogLevel.Log >= _logLevel)
        {
            Debug.LogFormat($"{ColorInfo("white", TimeInfo, "Info")}{format}", param);
        }
    }

    public void LogWarning(string format, params object[] param)
    {
        if (ELogLevel.Warning >= _logLevel)
        {
            Debug.LogWarningFormat($"{ColorInfo("yellow", TimeInfo, "Warning")}{format}", param);
        }
    }

    public void LogError(string format, params object[] param)
    {
        if (ELogLevel.Error >= _logLevel)
        {
            Debug.LogErrorFormat($"{ColorInfo("red", TimeInfo, "Error")}{format}", param);
        }
    }

    public void LogAssertion(string format, params object[] param)
    {
        if (ELogLevel.Assert >= _logLevel)
        {
            Debug.LogAssertionFormat($"{ColorInfo("brown", TimeInfo, "Assert")}{format}", param);
        }
    }

    public void LogException(Exception exception)
    {
        if (ELogLevel.Exception >= _logLevel)
        {
            Debug.LogError($"{ColorInfo("maroon", TimeInfo, "Exception")}");
            Debug.LogException(exception);
        }
    }
}
