//HintName: G.Models.LogItemLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Included only in responses
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LogItemLevel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DEBUG")]
        Debug,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ERROR")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="INFO")]
        Info,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TRACE")]
        Trace,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="WARN")]
        Warn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LogItemLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LogItemLevel value)
        {
            return value switch
            {
                LogItemLevel.Debug => "DEBUG",
                LogItemLevel.Error => "ERROR",
                LogItemLevel.Info => "INFO",
                LogItemLevel.Trace => "TRACE",
                LogItemLevel.Warn => "WARN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LogItemLevel? ToEnum(string value)
        {
            return value switch
            {
                "DEBUG" => LogItemLevel.Debug,
                "ERROR" => LogItemLevel.Error,
                "INFO" => LogItemLevel.Info,
                "TRACE" => LogItemLevel.Trace,
                "WARN" => LogItemLevel.Warn,
                _ => null,
            };
        }
    }
}