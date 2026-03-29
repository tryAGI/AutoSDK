//HintName: G.Models.LogLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of the sandbox
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LogLevel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="debug")]
        Debug,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="info")]
        Info,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="warn")]
        Warn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LogLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LogLevel value)
        {
            return value switch
            {
                LogLevel.Debug => "debug",
                LogLevel.Error => "error",
                LogLevel.Info => "info",
                LogLevel.Warn => "warn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LogLevel? ToEnum(string value)
        {
            return value switch
            {
                "debug" => LogLevel.Debug,
                "error" => LogLevel.Error,
                "info" => LogLevel.Info,
                "warn" => LogLevel.Warn,
                _ => null,
            };
        }
    }
}