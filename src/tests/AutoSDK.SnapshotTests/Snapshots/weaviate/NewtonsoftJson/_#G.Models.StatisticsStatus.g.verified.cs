//HintName: G.Models.StatisticsStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Node's status.<br/>
    /// Default Value: HEALTHY
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum StatisticsStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="HEALTHY")]
        HEALTHY,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="UNHEALTHY")]
        UNHEALTHY,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="UNAVAILABLE")]
        UNAVAILABLE,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TIMEOUT")]
        TIMEOUT,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StatisticsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StatisticsStatus value)
        {
            return value switch
            {
                StatisticsStatus.HEALTHY => "HEALTHY",
                StatisticsStatus.UNHEALTHY => "UNHEALTHY",
                StatisticsStatus.UNAVAILABLE => "UNAVAILABLE",
                StatisticsStatus.TIMEOUT => "TIMEOUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StatisticsStatus? ToEnum(string value)
        {
            return value switch
            {
                "HEALTHY" => StatisticsStatus.HEALTHY,
                "UNHEALTHY" => StatisticsStatus.UNHEALTHY,
                "UNAVAILABLE" => StatisticsStatus.UNAVAILABLE,
                "TIMEOUT" => StatisticsStatus.TIMEOUT,
                _ => null,
            };
        }
    }
}