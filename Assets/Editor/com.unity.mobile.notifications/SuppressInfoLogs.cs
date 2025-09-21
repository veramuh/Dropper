#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

[InitializeOnLoad]
public class SuppressInfoLogs
{
    static SuppressInfoLogs()
    {
        Application.logMessageReceived += (condition, stackTrace, type) =>
        {
            if (condition.Contains("Adaptive Performance is disabled via Settings"))
                type = LogType.Exception; // verhindert Anzeige im Console-Filter „Log“
        };
    }
}
#endif
