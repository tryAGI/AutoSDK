//HintName: G.Models.MetadataSendTelemetryRequestEventVariant5Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MetadataSendTelemetryRequestEventVariant5Type
    {
        /// <summary>
        /// 
        /// </summary>
        UserInput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MetadataSendTelemetryRequestEventVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MetadataSendTelemetryRequestEventVariant5Type value)
        {
            return value switch
            {
                MetadataSendTelemetryRequestEventVariant5Type.UserInput => "user_input",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MetadataSendTelemetryRequestEventVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "user_input" => MetadataSendTelemetryRequestEventVariant5Type.UserInput,
                _ => null,
            };
        }
    }
}