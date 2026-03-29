//HintName: G.Models.MetadataSendTelemetryRequestEventVariant3Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MetadataSendTelemetryRequestEventVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        ToolUsage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MetadataSendTelemetryRequestEventVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MetadataSendTelemetryRequestEventVariant3Type value)
        {
            return value switch
            {
                MetadataSendTelemetryRequestEventVariant3Type.ToolUsage => "tool_usage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MetadataSendTelemetryRequestEventVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "tool_usage" => MetadataSendTelemetryRequestEventVariant3Type.ToolUsage,
                _ => null,
            };
        }
    }
}