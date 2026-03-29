//HintName: G.Models.MetadataSendTelemetryRequestEventVariant4Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MetadataSendTelemetryRequestEventVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MetadataSendTelemetryRequestEventVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MetadataSendTelemetryRequestEventVariant4Type value)
        {
            return value switch
            {
                MetadataSendTelemetryRequestEventVariant4Type.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MetadataSendTelemetryRequestEventVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "error" => MetadataSendTelemetryRequestEventVariant4Type.Error,
                _ => null,
            };
        }
    }
}