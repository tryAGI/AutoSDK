//HintName: G.Models.MetadataSendTelemetryRequestService.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MetadataSendTelemetryRequestService
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="letta-code")]
        LettaCode,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MetadataSendTelemetryRequestServiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MetadataSendTelemetryRequestService value)
        {
            return value switch
            {
                MetadataSendTelemetryRequestService.LettaCode => "letta-code",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MetadataSendTelemetryRequestService? ToEnum(string value)
        {
            return value switch
            {
                "letta-code" => MetadataSendTelemetryRequestService.LettaCode,
                _ => null,
            };
        }
    }
}