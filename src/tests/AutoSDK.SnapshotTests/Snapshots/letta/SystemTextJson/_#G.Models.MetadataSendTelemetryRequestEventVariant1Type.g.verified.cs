//HintName: G.Models.MetadataSendTelemetryRequestEventVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MetadataSendTelemetryRequestEventVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        SessionStart,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MetadataSendTelemetryRequestEventVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MetadataSendTelemetryRequestEventVariant1Type value)
        {
            return value switch
            {
                MetadataSendTelemetryRequestEventVariant1Type.SessionStart => "session_start",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MetadataSendTelemetryRequestEventVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "session_start" => MetadataSendTelemetryRequestEventVariant1Type.SessionStart,
                _ => null,
            };
        }
    }
}