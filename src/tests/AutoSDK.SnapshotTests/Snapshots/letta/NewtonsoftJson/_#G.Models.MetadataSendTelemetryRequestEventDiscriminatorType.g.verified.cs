//HintName: G.Models.MetadataSendTelemetryRequestEventDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MetadataSendTelemetryRequestEventDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="session_end")]
        SessionEnd,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="session_start")]
        SessionStart,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool_usage")]
        ToolUsage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user_input")]
        UserInput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MetadataSendTelemetryRequestEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MetadataSendTelemetryRequestEventDiscriminatorType value)
        {
            return value switch
            {
                MetadataSendTelemetryRequestEventDiscriminatorType.Error => "error",
                MetadataSendTelemetryRequestEventDiscriminatorType.SessionEnd => "session_end",
                MetadataSendTelemetryRequestEventDiscriminatorType.SessionStart => "session_start",
                MetadataSendTelemetryRequestEventDiscriminatorType.ToolUsage => "tool_usage",
                MetadataSendTelemetryRequestEventDiscriminatorType.UserInput => "user_input",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MetadataSendTelemetryRequestEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "error" => MetadataSendTelemetryRequestEventDiscriminatorType.Error,
                "session_end" => MetadataSendTelemetryRequestEventDiscriminatorType.SessionEnd,
                "session_start" => MetadataSendTelemetryRequestEventDiscriminatorType.SessionStart,
                "tool_usage" => MetadataSendTelemetryRequestEventDiscriminatorType.ToolUsage,
                "user_input" => MetadataSendTelemetryRequestEventDiscriminatorType.UserInput,
                _ => null,
            };
        }
    }
}