using System.Diagnostics;
using System;

namespace StalkerME
{
    public sealed class Debuger
    {
        private const string condition = "PRINT";

        [Conditional (condition)]
        public static void Log(object message)
        {
            UnityEngine.Debug.Log(message);
        }

        [Conditional (condition)]
        public static void LogFormat(string format, params object[] args)
        {
            UnityEngine.Debug.LogFormat(format, args);
        }

        [Conditional (condition)]
        public static void LogWarning(object message)
        {
            UnityEngine.Debug.LogWarning(message);
        }

        [Conditional (condition)]
        public static void LogWarningFormat(string format, params object[] args)
        {
            UnityEngine.Debug.LogWarningFormat(format, args);
        }

        [Conditional (condition)]
        public static void LogError(object message)
        {
            UnityEngine.Debug.LogError(message);
        }

        [Conditional(condition)]
        public static void LogError(string tag, object message)
        {
            UnityEngine.Debug.unityLogger.LogError(tag, message);
        }

        [Conditional (condition)]
        public static void LogErrorFormat(string format, params object[] args)
        {
            UnityEngine.Debug.LogErrorFormat(format, args);
        }

        [Conditional (condition)]
        public static void LogException(Exception exception)
        {
            UnityEngine.Debug.LogException(exception);
        }

        [Conditional (condition)]
        public static void LogAssertionFormat(bool condition, string format, params object[] args)
        {
            UnityEngine.Debug.AssertFormat(condition, format, args);
        }

        [Conditional (condition)]
        public static void LogAssertionFormat(bool condition, UnityEngine.Object context, string format, params object[] args)
        {
            UnityEngine.Debug.AssertFormat(condition, context, format, args);
        }
    }
}
