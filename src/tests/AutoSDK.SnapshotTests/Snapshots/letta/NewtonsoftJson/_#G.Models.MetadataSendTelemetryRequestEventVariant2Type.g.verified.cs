//HintName: G.Models.MetadataSendTelemetryRequestEventVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MetadataSendTelemetryRequestEventVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="session_end")]
        SessionEnd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MetadataSendTelemetryRequestEventVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MetadataSendTelemetryRequestEventVariant2Type value)
        {
            return value switch
            {
                MetadataSendTelemetryRequestEventVariant2Type.SessionEnd => "session_end",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MetadataSendTelemetryRequestEventVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "session_end" => MetadataSendTelemetryRequestEventVariant2Type.SessionEnd,
                _ => null,
            };
        }
    }
}