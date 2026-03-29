//HintName: G.Models.AlertIncidentResponseThresholdType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether threshold is absolute or relative to previous period.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AlertIncidentResponseThresholdType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="absolute")]
        Absolute,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="relative")]
        Relative,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlertIncidentResponseThresholdTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertIncidentResponseThresholdType value)
        {
            return value switch
            {
                AlertIncidentResponseThresholdType.Absolute => "absolute",
                AlertIncidentResponseThresholdType.Relative => "relative",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertIncidentResponseThresholdType? ToEnum(string value)
        {
            return value switch
            {
                "absolute" => AlertIncidentResponseThresholdType.Absolute,
                "relative" => AlertIncidentResponseThresholdType.Relative,
                _ => null,
            };
        }
    }
}