//HintName: G.Models.HealthServiceStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The health status of the service
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum HealthServiceStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="degraded")]
        Degraded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="down")]
        Down,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="healthy")]
        Healthy,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unknown")]
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HealthServiceStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HealthServiceStatus value)
        {
            return value switch
            {
                HealthServiceStatus.Degraded => "degraded",
                HealthServiceStatus.Down => "down",
                HealthServiceStatus.Healthy => "healthy",
                HealthServiceStatus.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HealthServiceStatus? ToEnum(string value)
        {
            return value switch
            {
                "degraded" => HealthServiceStatus.Degraded,
                "down" => HealthServiceStatus.Down,
                "healthy" => HealthServiceStatus.Healthy,
                "unknown" => HealthServiceStatus.Unknown,
                _ => null,
            };
        }
    }
}